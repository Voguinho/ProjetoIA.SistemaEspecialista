namespace SistemaEspecialista.Domain.Entities;

public class ObjectiveCharacteristic : Entity
{
    public int ProjectId { get; set; }
    public int CharacteristicId { get; set; }
    public int ObjectiveId { get; set; }
}
