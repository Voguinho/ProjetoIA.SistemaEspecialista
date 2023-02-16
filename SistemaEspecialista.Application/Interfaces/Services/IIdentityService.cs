using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.Application.Interfaces.Services;

public interface IIdentityService
{
    public User GetCurrentUser();
    public User IsAuthenticated();
}
