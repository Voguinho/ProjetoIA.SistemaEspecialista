using SistemaEspecialista.Application.Common.Mapping;
using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.Application.DTOs.Characteristics;

public record AddCharacteristicDto : IMapFrom<Characteristic>
{
}
