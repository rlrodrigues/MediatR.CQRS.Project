using MediatR.CQRS.Project.Domain.Models.Response;

namespace MediatR.CQRS.Project.Domain.Commands
{
    public class CreateUserCommand : IRequest<Unit>
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }
}