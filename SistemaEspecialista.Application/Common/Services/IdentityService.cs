using Microsoft.AspNetCore.Http;
using SistemaEspecialista.Application.Interfaces.Services;
using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.Application.Common.Services;

public class IdentityService : IIdentityService
{
    private readonly IHttpContextAccessor _accessor;

    public IdentityService(IHttpContextAccessor accessor)
    {
        _accessor = accessor;
    }

    public User GetCurrentUser()
    {
        throw new NotImplementedException();
    }

    public User IsAuthenticated()
    {
        throw new NotImplementedException();
    }
}
