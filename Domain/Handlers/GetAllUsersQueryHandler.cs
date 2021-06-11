using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR.CQRS.Project.Domain.Models.Response;
using MediatR.CQRS.Project.Domain.Queries;

namespace MediatR.CQRS.Project.Domain.Handlers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<UserResponse>>
    {
        public async Task<IEnumerable<UserResponse>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = new List<UserResponse>()
            {
                new UserResponse
                {
                    Id = Guid.NewGuid(),
                    Name = "Ruan",
                    Email = "a@a.com"
                },
                new UserResponse
                {
                    Id = Guid.NewGuid(),
                    Name = "Lucas",
                    Email = "b@b.com"
                }
            };

            return await Task.FromResult(users);
        }
    }
}