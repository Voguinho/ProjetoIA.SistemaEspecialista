using Moq;
using SistemaEspecialista.Application.Interfaces.Engines;
using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Infrastructure.Utils;

namespace SistemaEspecialista.Infrastructure.Test.Engines;

public class InferenceEngineTest
{
    private readonly Mock<IProjectRepository> _projectRepository = new();
    private readonly Mock<IObjectiveRepository> _objectiveRepository = new();
    private readonly Mock<ICharacteristicsRepository> _characteristicsRepository = new();
    private readonly Mock<IObjectiveCharacteristicRepository> _objectiveCharacteristicRepository = new();
    private readonly Mock<ILogRepository> _logRepository = new();
    private readonly IInferenceEngine _inferenceEngine;

    public InferenceEngineTest()
    {
        _inferenceEngine = ServiceProviderUtils.GetService<IInferenceEngine>();
    }
}
