using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Users_API.Business.Querries;
using Users_API.Data;

namespace Users_API.Business.Handlers
{
  public class AuthenticateUserHandler : IRequestHandler<AuthenticateUserQuery, Dictionary<string, object>>
  {
    private readonly UserContext UserContext;
    private readonly IMediator _mediator;
    private readonly IConfiguration Configuration;
    public AuthenticateUserHandler(UserContext userContext, IMediator mediator, IConfiguration configuration)
    {
      UserContext = userContext;
      _mediator = mediator;
      Configuration = configuration;

    }

    public async Task<Dictionary<string, object>> Handle(AuthenticateUserQuery request, CancellationToken cancellationToken)
    {
      var response = new Dictionary<string, object>();
      var user = UserContext.Users.Where(u => u.UserName == request.Username && u.Password == request.Password).FirstOrDefault();

      response.Add("user", user);
      return response;
    }
  }
  }
