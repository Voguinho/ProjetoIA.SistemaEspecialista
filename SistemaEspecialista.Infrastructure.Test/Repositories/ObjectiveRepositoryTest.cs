using NUnit.Framework;
using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Domain.Utils;
using SistemaEspecialista.Infrastructure.Utils;

namespace SistemaEspecialista.Infrastructure.Test.Repositories;

public class ObjectiveRepositoryTest
{
    private readonly IObjectiveRepository _objectiveRepository;
    private int? _objectiveId;

    public ObjectiveRepositoryTest()
    {
        _objectiveRepository = ServiceProviderUtils.GetService<IObjectiveRepository>();
    }

    [Test]
    public void Add_Should_Return_Objective_With_Valid_Id()
    {
        var ObjectiveToAdd = new Objective { Id = 0, Name = "Test Objective 1", Description = " Test" };
        var result = _objectiveRepository.Add(ObjectiveToAdd, CancellationToken.None).Result;

        _objectiveId = result.Id;
        Assert.IsTrue(result.Id != DefaultValues.IdNullValue && result.CreatedAt is not null);
    }

    [Test]
    public void Get_By_Id_Should_Return_Objective_With_Valid_Id()
    {
        var Objective = _objectiveRepository.GetById(_objectiveId ?? 1, CancellationToken.None).Result;
        Assert.IsNotNull(Objective);
    }

    [Test]
    public void Update_Should_Return_Objective_With_The_Updated_Field()
    {
        var Objective = _objectiveRepository.GetById(_objectiveId ?? 1, CancellationToken.None).Result;

        if (Objective is null)
            Assert.Ignore($"não foi encontrado o registro de ID: {_objectiveId ?? 1} para atualizar.");

        Objective.Name = "Test Objective 1 UPDATED";
        Objective.Description = " Test UPDATED";

        var ObjectiveResult = _objectiveRepository.Update(Objective).Result;

        Assert.IsTrue(ObjectiveResult.UpdatedAt.HasValue && Objective.Name == "Test Objective 1 UPDATED");
    }

    [Test]
    public void Get_All_Should_Return_Objective_IEnumerable()
    {
        var Objectives = _objectiveRepository.GetAll(CancellationToken.None).Result;
        Assert.IsNotNull(Objectives);
        Assert.IsInstanceOf<IEnumerable<Objective>>(Objectives);
    }

    [Test]
    public void Remove_Should_Return_Objective()
    {
        var Objective = _objectiveRepository.GetById(_objectiveId ?? 1, CancellationToken.None).Result;
        if (Objective is null)
            Assert.Ignore($"não foi encontrado o registro de ID: {_objectiveId ?? 1} para remover.");

        var removedObjective = _objectiveRepository.Remove(Objective).Result;
        Assert.IsNotNull(removedObjective);
    }
}
