using System.Globalization;
using System.Reflection.PortableExecutable;

namespace FirstStep;

public class Carro
{
    public void ligar()
    {
        Console.WriteLine("Carro LIGADO");
    }

    public void desligar()
    {
        Console.WriteLine("Carro DESLIGADO");
    }

    private void Teste1()
    {
        ligar();
    }

    internal void Teste2()
    {

    }

    public string Modelo { get; set; }
    public DateOnly LancadoEm { get; set; }
    public Cor Cor { get; set; }

    public Carro(string modelo){
        Modelo = modelo;
    }

    public void NomeDoModelo() => Console.WriteLine(Modelo);
   
}

