using AutoMapper;

namespace SistemaEspecialista.Application.Common.Mapping;

public interface IMapFrom<T>
{
    void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType()).ReverseMap();
}
