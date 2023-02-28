using SistemaEspecialista.Application.Common.Mapping;
using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.Application.DTOs.Projects;

public record AddProjectDto : IMapFrom<Project>
{
}
