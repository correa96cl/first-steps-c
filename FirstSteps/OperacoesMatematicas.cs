namespace FirstStep;

public class OperacoesMatematicas
{

    //create function named sumar with two int parameters
    public (string autorSoma, int resultadoSomaFinal) sumar(int num1, int num2){
        var resultadoSoma = num1 + num2;
        return ("Soma: ", resultadoSoma);
    }

    //create function named subtrair with two int parameters
    public (string autorSustracao, int resultadoSustracaoFinal) subtrair(int num1, int num2){
        var resultadoSubtracao = num1 - num2;
        return ("Subtração: ", resultadoSubtracao); 
    }

//create one void method named multiplicar with two int parameters
    public void multiplicar(int num1, int num2=7, string autor= "Marcelo Valderrama Correa"){
        Console.WriteLine($"Multiplicação: {num1 * num2}");
        Console.WriteLine($"Autor: {autor}");
    }
    
    


}