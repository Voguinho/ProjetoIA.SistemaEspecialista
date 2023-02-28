using NUnit.Framework;
using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Domain.Utils;
using SistemaEspecialista.Infrastructure.Utils;

namespace SistemaEspecialista.Infrastructure.Test.Repositories;

public class CharacteristicRepositoryTest
{
    private readonly ICharacteristicsRepository _characteristicsRepository;
    private int? _characteristicId;

    public CharacteristicRepositoryTest()
    {
        _characteristicsRepository = ServiceProviderUtils.GetService<ICharacteristicsRepository>();
    }

    [Test]
    public void Add_Should_Return_Characteristic_With_Valid_Id()
    {
        var CharacteristicToAdd = new Characteristic { Id = 0, Name = "Test Characteristic 1", Description = " Test" };
        var result = _characteristicsRepository.Add(CharacteristicToAdd, CancellationToken.None).Result;

        _characteristicId = result.Id;
        Assert.IsTrue(result.Id != DefaultValues.IdNullValue && result.CreatedAt is not null);
    }

    [Test]
    public void Get_By_Id_Should_Return_Characteristic_With_Valid_Id()
    {
        var Characteristic = _characteristicsRepository.GetById(_characteristicId ?? 1, CancellationToken.None).Result;
        Assert.IsNotNull(Characteristic);
    }

    [Test]
    public void Update_Should_Return_Characteristic_With_The_Updated_Field()
    {
        var Characteristic = _characteristicsRepository.GetById(_characteristicId ?? 1, CancellationToken.None).Result;

        if (Characteristic is null)
            Assert.Ignore($"não foi encontrado o registro de ID: {_characteristicId ?? 1} para atualizar.");

        Characteristic.Name = "Test Characteristic 1 UPDATED";
        Characteristic.Description = " Test UPDATED";

        var CharacteristicResult = _characteristicsRepository.Update(Characteristic).Result;

        Assert.IsTrue(CharacteristicResult.UpdatedAt.HasValue && Characteristic.Name == "Test Characteristic 1 UPDATED");
    }

    [Test]
    public void Get_All_Should_Return_Characteristic_IEnumerable()
    {
        var Characteristics = _characteristicsRepository.GetAll(CancellationToken.None).Result;
        Assert.IsNotNull(Characteristics);
        Assert.IsInstanceOf<IEnumerable<Characteristic>>(Characteristics);
    }

    [Test]
    public void Remove_Should_Return_Characteristic()
    {
        var Characteristic = _characteristicsRepository.GetById(_characteristicId ?? 1, CancellationToken.None).Result;
        if (Characteristic is null)
            Assert.Ignore($"não foi encontrado o registro de ID: {_characteristicId ?? 1} para remover.");

        var removedCharacteristic = _characteristicsRepository.Remove(Characteristic).Result;
        Assert.IsNotNull(removedCharacteristic);
    }
}
