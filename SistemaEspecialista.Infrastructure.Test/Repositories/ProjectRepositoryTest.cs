using NUnit.Framework;
using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Domain.Utils;
using SistemaEspecialista.Infrastructure.Test.Utils;

namespace SistemaEspecialista.Infrastructure.Test.Repositories
{
    public class ProjectRepositoryTest
    {
        private readonly IProjectRepository _projectRepository;
        private int? _projectId;

        public ProjectRepositoryTest()
        {
            _projectRepository = ServiceProviderUtils.GetService<IProjectRepository>();
        }

        [Test]
        public void Add_Should_Return_Project_With_Valid_Id()
        {
            var projectToAdd = new Project { Id = 0, Name ="Test project 1", Description =" Test" };
            var result = _projectRepository.Add(projectToAdd, CancellationToken.None).Result;

            _projectId  = result.Id;
            Assert.IsTrue(result.Id != DefaultValues.IdNullValue && result.CreatedAt is not null);
        }

        [Test]
        public void Get_By_Id_Should_Return_Project_With_Valid_Id()
        {
            var project = _projectRepository.GetById(_projectId ?? 1, CancellationToken.None).Result;
            Assert.IsNotNull(project);
        }

        [Test]
        public void Update_Should_Return_Project_With_The_Updated_Field()
        {
            var project = _projectRepository.GetById(_projectId ?? 1, CancellationToken.None).Result;

            if (project is null)
                Assert.Ignore($"não foi encontrado o registro de ID: {_projectId ?? 1} para atualizar.");

            project.Name = "Test project 1 UPDATED";
            project.Description = " Test UPDATED";

            var projectResult = _projectRepository.Update(project).Result;

            Assert.IsTrue(projectResult.UpdatedAt.HasValue && project.Name == "Test project 1 UPDATED");
        }

        [Test]
        public void Get_All_Should_Return_Project_IEnumerable()
        {
            var projects = _projectRepository.GetAll(CancellationToken.None).Result;
            Assert.IsNotNull(projects);
            Assert.IsInstanceOf<IEnumerable<Project>>(projects);
        }

        [Test]
        public void Remove_Should_Return_Project()
        {
            var project = _projectRepository.GetById(_projectId ?? 1, CancellationToken.None).Result;
            if (project is null)
                Assert.Ignore($"não foi encontrado o registro de ID: {_projectId ?? 1} para remover.");

            var removedProject = _projectRepository.Remove(project).Result;
            Assert.IsNotNull(removedProject);
        }
    }
}
