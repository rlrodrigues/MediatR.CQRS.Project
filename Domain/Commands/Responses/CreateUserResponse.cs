using System;

namespace MediatR.CQRS.Project.Domain.Commands.Response
{
    public class CreateUserResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}