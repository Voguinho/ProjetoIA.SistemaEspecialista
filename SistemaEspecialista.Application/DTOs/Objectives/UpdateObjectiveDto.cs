using SistemaEspecialista.Application.Common.Mapping;
using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.Application.DTOs.Objectives;

public record UpdateObjectiveDto : IMapFrom<Objective>
{
}
