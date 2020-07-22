using MediatR;
using System.Collections.Generic;

namespace Users_API.Business.Querries
{
  public class AuthenticateUserQuery : IRequest<Dictionary<string, object>>
  {
    public string Username { get; set; }
    public string Password { get; set; }

    public AuthenticateUserQuery(string username, string password)
    {
      Username = username;
      Password = password;
    }
  }
}
