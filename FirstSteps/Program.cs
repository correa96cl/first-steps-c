using System.Globalization;
using System.Reflection.Metadata;
using System.Text;
using FirstStep.Teste;

namespace FirstStep;

class Program
{

    enum NivelDeDficiculdade{
        Baixo,
        Medio,
        Alto
    }
    static void Main()
    {
        NivelDeDficiculdade nivel = NivelDeDficiculdade.Alto;


        int numero = 7;
        long longevo = 7;
        uint enterou = 7;
        sbyte byte2 = 127;
        double numeroDoble = 3.14;
        float numeroFloat = 3.14f;
        decimal numeroDecimal = 3.14m;
        bool ativo = false;
        bool inativo = true;
        char letra = 'a';
        char  numeroChar = '1';
        char caracter = '0';
        string texto = "Hola";
        char primeiraLetraDoTexto = texto[0];
        string meuNome = "  Marcelo ";
        string meuNomeSemEspacos = meuNome.Trim();
        bool comecaComALetraW = meuNomeSemEspacos.StartsWith("W");
        bool acabaComALetraW = meuNomeSemEspacos.EndsWith("o");
        string textoAposReplace = meuNomeSemEspacos.Replace('e', '7');
        bool existe = meuNomeSemEspacos.Contains("elo");
        bool existe2 = meuNomeSemEspacos.Equals("elo");

        string texto1 = "A orimeira frase";
        string texto2 = "segundo frase";

        string paragrafo = texto1 + " " +texto2 + true + " "+ 8;
        string paragrafo2 = $"A primeira frase. {7} {true} segunda frase";
        StringBuilder builder = new StringBuilder();

        builder.Append(paragrafo);
        builder.Append(paragrafo2);

        string textoFormatda = "O Usuario {0} gosta do numero {1}";

        string resultado2 = string.Format(textoFormatda, "Marcelo", 4);
        DateOnly dia = new DateOnly(2024, 05, 26);
        string diaEmTexto = dia.ToShortDateString();
        string diaEmtextoLong = dia.ToLongDateString();
        string diaEmPortugues = dia.ToString(new CultureInfo("pt-BR"));
        string diaemPortuguesFormatada = dia.ToString("d MM yyyy",new CultureInfo("pt-BR"));
        string diaemPortuguesFormatadas = dia.ToString("dd/MMM/yyyy", new CultureInfo("pt-BR"));
        DateTime dia1 = new DateTime(2023, 12, 1, 20, 06, 1);
        DateTime hoje = DateTime.Today;
        DateTime hojeUtc = DateTime.UtcNow;
        DateTime novoDia = hojeUtc.AddDays(1);
        object minhaVariavelObject = new Carro();
        int? idade = null;
        bool informouIdade = idade.HasValue;


        Console.WriteLine(texto);
        Console.WriteLine(primeiraLetraDoTexto);
        Console.WriteLine(meuNome);
        Console.WriteLine(meuNomeSemEspacos);
        Console.WriteLine(comecaComALetraW);
        Console.WriteLine(acabaComALetraW);
        Console.WriteLine(textoAposReplace);
        Console.WriteLine(existe);
        Console.WriteLine(existe2);
        Console.WriteLine(paragrafo);
        Console.WriteLine(paragrafo2);
        Console.WriteLine(builder);
        Console.WriteLine(resultado2);
        Console.WriteLine(dia);
        Console.WriteLine(diaEmTexto);
        Console.WriteLine(diaEmtextoLong);
        Console.WriteLine(diaEmPortugues);
        Console.WriteLine(diaemPortuguesFormatada);
        Console.WriteLine(diaemPortuguesFormatadas);
        Console.WriteLine(dia1);
        Console.WriteLine(hoje);
        Console.WriteLine(novoDia);
        Console.WriteLine(nivel);



        Console.WriteLine(numeroDecimal);
        Carro meuCarro = new Carro();
        meuCarro.ligar();
        meuCarro.desligar();
        meuCarro.Teste2();

        Biscoito meuBiscoito = new Biscoito();
        meuBiscoito.Temperatura();
    }
}