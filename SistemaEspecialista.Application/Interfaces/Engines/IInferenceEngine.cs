using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.Application.Interfaces.Engines;

public interface IInferenceEngine
{
    public Task<List<Characteristic>> GetCharacteristicsByObjectives(List<Objective> objectives);
    public  Task<Objective> Evaluate(List<Characteristic> characteristics);
}
