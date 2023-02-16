namespace SistemaEspecialista.Application.Interfaces.Services;

public interface ICryptographyService
{
    string ComputeHash(string password, string salt, string pepper, int iteration);
    string GenerateSalt();
}
