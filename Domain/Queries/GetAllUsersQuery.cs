using System.Collections.Generic;
using MediatR.CQRS.Project.Domain.Models.Response;

namespace MediatR.CQRS.Project.Domain.Queries
{
    public class GetAllUsersQuery : IRequest<IEnumerable<UserResponse>>
    {
        
    }
}