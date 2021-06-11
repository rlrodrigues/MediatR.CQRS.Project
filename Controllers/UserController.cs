using System;
using System.Threading.Tasks;
using MediatR.CQRS.Project.Domain.Commands;
using MediatR.CQRS.Project.Domain.Models.Response;
using MediatR.CQRS.Project.Domain.Queries;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.CQRS.Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([FromServices] IMediator mediator, [FromBody] CreateUserCommand command)
        {
            try
            {
                var result = await mediator.Send(command);
                
                return Ok(result); 
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers([FromServices] IMediator mediator)
        {
            try
            {
                var query = new GetAllUsersQuery();
                var result = await mediator.Send(query);
                
                return Ok(result); 
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
