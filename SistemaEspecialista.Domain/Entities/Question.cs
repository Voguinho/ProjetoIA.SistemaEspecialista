namespace SistemaEspecialista.Domain.Entities;

public class Question : Entity
{
    public int ProjectId { get; set; }
    public int CharacteristicId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public Characteristic Characteristic { get; set; }
}
