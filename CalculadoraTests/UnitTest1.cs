using Xunit;

public class UnitTest1
{
    [Fact]
    public void Sumar_DeberiaRetornarLaSumaCorrecta()
    {
        // 1. Arrange (Preparar los datos)
        Calculadora calc = new Calculadora();
        double numero1 = 5;
        double numero2 = 3;

        // 2. Act (Ejecutar el método que queremos probar)
        double resultado = calc.Sumar(numero1, numero2);

        // 3. Assert (Verificar que el resultado sea el esperado)
        Assert.Equal(8, resultado); 
    }

     [Fact]
    public void Integracion_DeberiaCalcularPromedioUsandoSumaYDivision()
    {
        // 1. Arrange (Preparar)
        Calculadora calc = new Calculadora();
        double nota1 = 8;
        double nota2 = 6;

        // 2. Act (Ejecutar el circuito operativo)
        // Primero sumamos
        double suma = calc.Sumar(nota1, nota2); 
        // Luego dividimos el resultado de la suma
        double promedio = calc.Dividir(suma, 2); 

        // 3. Assert (Verificar que 8 + 6 = 14, y 14 / 2 = 7)
        Assert.Equal(7, promedio); 
    }
}