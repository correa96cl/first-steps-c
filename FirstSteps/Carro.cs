namespace FirstStep;

class Carro{
    public void ligar(){
        Console.WriteLine("Carro LIGADO");
    }

    public void desligar(){
        Console.WriteLine("Carro DESLIGADO");
    }

    private void Teste1(){
        ligar();
    }

    internal void Teste2(){
        
    }
}