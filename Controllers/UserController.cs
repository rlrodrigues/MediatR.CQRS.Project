using System;
using System.Threading.Tasks;
using MediatR.CQRS.Project.Domain.Commands.Requests;
using MediatR.CQRS.Project.Domain.Commands.Response;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.CQRS.Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("Create")]
        public Task<CreateUserResponse> Create([FromServices] IMediator mediator, [FromBody] CreateUserRequest request)
        {
            try
            {
                var result = mediator.Send(request);

                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
