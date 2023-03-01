using SistemaEspecialista.Application.Interfaces.Engines;
using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.Infrastructure.Engines;

public class InferenceEngine : IInferenceEngine
{
    private readonly IProjectRepository _projectRepository;
    private readonly IObjectiveRepository _objectiveRepository;
    private readonly ICharacteristicsRepository _characteristicsRepository;
    private readonly IObjectiveCharacteristicRepository _objectiveCharacteristicRepository;
    private readonly ILogRepository _logRepository;

    public InferenceEngine(
        IProjectRepository projectRepository,
        IObjectiveRepository objectiveRepository,
        ICharacteristicsRepository characteristicsRepository,
        IObjectiveCharacteristicRepository objectiveCharacteristicRepository,
        ILogRepository logRepository)
    {
        _projectRepository = projectRepository;
        _objectiveRepository = objectiveRepository;
        _characteristicsRepository = characteristicsRepository;
        _objectiveCharacteristicRepository = objectiveCharacteristicRepository;
        _logRepository = logRepository;
    }

    public Task<Objective> Evaluate(List<Characteristic> characteristics)
    {
        throw new NotImplementedException();
    }

    public Task<List<Characteristic>> GetCharacteristicsByObjectives(List<Objective> objectives)
    {
        throw new NotImplementedException();
    }
}
