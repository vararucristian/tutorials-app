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

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    
    [HttpPost]
    public async Task<ActionResult<string>> Authorize([FromBody]AuthenticateUserQuery userCredentials)
    {
      var response = await _mediator.Send(userCredentials);
      var json = JsonSerializer.Serialize(response);
      return json;
    }
=======
=======
>>>>>>> e8f90eb5f83bf7694033df1554170043a7fc9ebf
=======
>>>>>>> e8f90eb5f83bf7694033df1554170043a7fc9ebf
    [HttpGet("{userName}/{password}")]
    public async Task<ActionResult<string>> Authorize(string userName, string password)
    {
      var response = await _mediator.Send(new AuthenticateUserQuery(userName, password));
      var json = JsonSerializer.Serialize(response);
      return json;
    }

<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> e8f90eb5f83bf7694033df1554170043a7fc9ebf
=======
>>>>>>> e8f90eb5f83bf7694033df1554170043a7fc9ebf
=======
>>>>>>> e8f90eb5f83bf7694033df1554170043a7fc9ebf
  }
}
