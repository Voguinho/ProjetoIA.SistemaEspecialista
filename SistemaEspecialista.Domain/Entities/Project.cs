namespace SistemaEspecialista.Domain.Entities;

public class Project : Entity
{
    public string Name { get; set; }
    public string Description { get; set; }

    public List<Objective> Objectives { get; set; } = new();
}
