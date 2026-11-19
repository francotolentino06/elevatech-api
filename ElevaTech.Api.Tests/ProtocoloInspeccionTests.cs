using ElevaTech.Api.Reglas;
using Xunit;
namespace ElevaTech.Api.Tests;
public class ProtocoloInspeccionTests
{
    [Fact] public void DebeIncluirCadaItemDelEquipoUnaVez()
    {
        var items=ProtocoloInspeccion.Items("Ascensor");
        Assert.True(ProtocoloInspeccion.Completo("Ascensor",items.Reverse()));
        Assert.False(ProtocoloInspeccion.Completo("Ascensor",items.Skip(1)));
        Assert.False(ProtocoloInspeccion.Completo("Ascensor",items.Take(4).Append("Ruidos")));
        Assert.False(ProtocoloInspeccion.Completo("Desconocido",items));
    }
}
