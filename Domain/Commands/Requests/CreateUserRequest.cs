using MediatR.CQRS.Project.Domain.Commands.Response;

namespace MediatR.CQRS.Project.Domain.Commands.Requests
{
    public class CreateUserRequest : IRequest<CreateUserResponse>
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }
}