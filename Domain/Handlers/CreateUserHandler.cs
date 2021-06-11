using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR.CQRS.Project.Domain.Commands.Requests;
using MediatR.CQRS.Project.Domain.Commands.Response;

namespace  MediatR.CQRS.Project.Domain.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserRequest, CreateUserResponse>
    {
        public Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateUserResponse
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Email = request.Email,
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}