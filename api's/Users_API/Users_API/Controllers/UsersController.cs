using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Users_API.Business.Querries;

namespace Users_API.Controllers
{
  [Route("api/users")]
  [ApiController]
  public class UsersController : ControllerBase
  {
    private readonly IMediator _mediator;
    public UsersController(IMediator mediator)
    {

      _mediator = mediator;

    }

    [HttpGet("{userName}/{password}")]
    public async Task<ActionResult<string>> Authorize(string userName, string password)
    {
      var response = await _mediator.Send(new AuthenticateUserQuery(userName, password));
      var json = JsonSerializer.Serialize(response);
      return json;
    }

  }
}
