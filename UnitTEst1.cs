
namespace Atividade Xunit;

public class UniTest1
{


[fact]
public void teste_calculo_IMC()
{
 double imc_previsto = 31.25;

 imc_previsto i = new imc_previsto();

 i.peso = 80;
 i.altura = 1.60;

 i.calcular_IMC();

 assert.Equal(imc_previsto, i.imc, 2);
}
}

[Theory]
[InlineData("Abaixo do peso", 50 , 1.80)]
[InlineData("Peso normal", 70 , 1.75)]
[InlineData("Sobrepeso", 85 , 1.75)]
[InlineData("Obesidade de Grau I", 95 , 1.75)]
[InlineData("Obesidade de Grau II", 110 , 1.75)]
[InlineData("Obesidade de Grau III", 130 , 1.75)]

public void  TEste_categoria_IMC (string catefgoriaEsperada, double peso, double altura)
{
    IMC i = new IMC();

    i.peso = peso;
    i.altura = altura;

    i.Calcular_imc();

    i.Classificar_IMC();

    Assert.Equal(catefgoriaEsperada, i.categoria);
}