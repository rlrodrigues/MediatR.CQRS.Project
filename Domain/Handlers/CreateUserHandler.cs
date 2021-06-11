using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR.CQRS.Project.Domain.Commands;
using MediatR.CQRS.Project.Domain.Models.Response;


namespace  MediatR.CQRS.Project.Domain.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, Unit>
    {
        public Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            // Adicionar utilizando repository
            return Task.FromResult(Unit.Value);
        }
    }
}