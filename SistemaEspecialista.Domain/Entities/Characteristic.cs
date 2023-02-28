namespace SistemaEspecialista.Domain.Entities;

public class Characteristic : Entity
{
    public int ProjectId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }
    public Question Question { get; set; }
}
