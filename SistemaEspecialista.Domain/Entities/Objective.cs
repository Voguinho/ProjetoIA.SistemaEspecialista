namespace SistemaEspecialista.Domain.Entities;

public class Objective : Entity
{
    public int ProjectId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}
