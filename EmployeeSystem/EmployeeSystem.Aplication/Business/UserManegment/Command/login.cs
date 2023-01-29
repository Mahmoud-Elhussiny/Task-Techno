using EmployeeSystem.Aplication.Auth;
using EmployeeSystem.Aplication.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EmployeeSystem.Aplication.Business.UserManegment.Command
{
    public class loginHandler : IRequestHandler<loginHandlerInput, loginHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly JWT _jwt;
        private readonly ILogger<loginHandler> _logger;
        public loginHandler(ILogger<loginHandler> logger, IDatabaseService databaseService,
            IHttpContextAccessor contextAccessor, IOptions<JWT> Jwt)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
            _jwt = Jwt.Value;
        }
        public async Task<loginHandlerOutput> Handle(loginHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling login business logic");
            loginHandlerOutput output = new loginHandlerOutput(request.CorrelationId());

            var userlogin = await _databaseService.Employees
                .FirstOrDefaultAsync(o => o.UserName == request.UserName
                && o.password == request.password);

            if (userlogin == null)
                throw new Exception("Invalid UserName Or Password");

            

            var claims = new[]
            {
                new Claim("Id",userlogin.Id.ToString()),
                new Claim("username", userlogin.UserName),
                new Claim(ClaimTypes.Role,userlogin.isAdmin?"admin":"user")
            };

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwt.Issuer,
                audience: _jwt.Audience,
                claims: claims,
                expires: DateTime.Now.AddDays(_jwt.DurationInDays),
                signingCredentials: signingCredentials);

            var activCon = new ActiveContext
            {
                IsAuthnticated = true,
                Name = userlogin.Name,
                token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
            };

          output.activeContext = activCon;

            return output;
        }
    }
}
