using NUnit.Framework;
using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Domain.Utils;
using SistemaEspecialista.Infrastructure.Utils;

namespace SistemaEspecialista.Infrastructure.Test.Repositories;

public class ObjectiveRepositoryTest
{
    private readonly IObjectiveRepository _objectiveRepository;
    private readonly IProjectRepository _projectRepository;
    private int? _objectiveId;

    public ObjectiveRepositoryTest()
    {
        _objectiveRepository = ServiceProviderUtils.GetService<IObjectiveRepository>();
        _projectRepository = ServiceProviderUtils.GetService<IProjectRepository>();
    }

    [Test]
    public void Add_Should_Return_Objective_With_Valid_Id()
    {
        var project = (_projectRepository.GetAll(CancellationToken.None).Result).FirstOrDefault();
        if (project == null)
            project = _projectRepository.Add(new Project { Name = "Projeto teste Objective", Description = "Projeto teste Objective" }, CancellationToken.None).Result;

        var ObjectiveToAdd = new Objective { Id = 0, ProjectId = project.Id, Name = "Test Objective 1", Description = " Test" };
        var result = _objectiveRepository.Add(ObjectiveToAdd, CancellationToken.None).Result;

        _objectiveId = result.Id;
        Assert.IsTrue(result.Id != DefaultValues.IdNullValue && result.CreatedAt is not null);

        _projectRepository.Remove(project);
        _objectiveRepository.Remove(ObjectiveToAdd);
    }

    [Test]
    public void Get_By_Id_Should_Return_Objective_With_Valid_Id()
    {
        var Objective = _objectiveRepository.GetById(_objectiveId ?? 1, CancellationToken.None).Result;
        Assert.IsNotNull(Objective);
    }

    [Test]
    public async Task Update_Should_Return_Objective_With_The_Updated_Field()
    {
        var project = await _projectRepository.Add(new Project { Name = "Projeto teste Objective", Description = "Projeto teste Objective" }, CancellationToken.None);
        var objective = await _objectiveRepository.Add(new Objective { Id = 0, ProjectId = project.Id, Name = "Test Objective 1", Description = " Test" }, CancellationToken.None);

        objective.Name = "Test Objective 1 UPDATED";
        objective.Description = " Test UPDATED";

        var ObjectiveResult = _objectiveRepository.Update(objective).Result;
        Assert.IsTrue(ObjectiveResult.UpdatedAt.HasValue && objective.Name == "Test Objective 1 UPDATED");

        var removedProject = _projectRepository.Remove(project).Result;
    }

    [Test]
    public void Get_All_Should_Return_Objective_IEnumerable()
    {
        var Objectives = _objectiveRepository.GetAll(CancellationToken.None).Result;
        Assert.IsNotNull(Objectives);
        Assert.IsInstanceOf<IEnumerable<Objective>>(Objectives);
    }

    [Test]
    public async Task Remove_Should_Return_Objective()
    {
        var project = await _projectRepository.Add(new Project { Name = "Projeto teste Objective", Description = "Projeto teste Objective" }, CancellationToken.None);
        var objective = await  _objectiveRepository.Add(new Objective { Id = 0, ProjectId = project.Id, Name = "Test Objective 1", Description = " Test" }, CancellationToken.None);

        var removedObjective = _objectiveRepository.Remove(objective).Result;
        var removedProject = _projectRepository.Remove(project).Result;
        Assert.IsNotNull(removedObjective);
    }
}
