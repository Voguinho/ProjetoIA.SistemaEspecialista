namespace SistemaEspecialista.Domain.Entities;

public class Log : Entity
{
    public int ProjectId { get; set; }
    public string? Context { get; set; }
    public string? Message { get; set; }
}
