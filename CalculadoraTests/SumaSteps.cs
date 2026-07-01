using TechTalk.SpecFlow;
using Xunit;

[Binding]
public class SumaSteps
{
    private double _numero1;
    private double _numero2;
    private double _resultado;
    
    // Traemos tu calculadora real para probarla
    private readonly Calculadora _calculadora = new Calculadora();

    [Given(@"que el primer número es (.*)")]
    public void DadoQueElPrimerNumeroEs(double numero)
    {
        _numero1 = numero;
    }

    [Given(@"el segundo número es (.*)")]
    public void DadoElSegundoNumeroEs(double numero)
    {
        _numero2 = numero;
    }

    [When(@"los sumo")]
    public void CuandoLosSumo()
    {
        // Aquí ejecutamos tu función real
        _resultado = _calculadora.Sumar(_numero1, _numero2);
    }

    [Then(@"el resultado debería ser (.*)")]
    public void EntoncesElResultadoDeberiaSer(double resultadoEsperado)
    {
        // Verificamos que el resultado coincida
        Assert.Equal(resultadoEsperado, _resultado);
    }
}