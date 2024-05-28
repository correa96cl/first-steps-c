using System.Globalization;
using System.Reflection.Metadata;
using System.Text;
using FirstStep.Teste;

namespace FirstStep;

class Program
{

    enum NivelDeDficiculdade
    {
        Baixo,
        Medio,
        Alto
    }
    static void Main()
    {

        var lista = new List<string> { "Marcelo", "Valderrama", "Correa" };
        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine($"Nome: {lista[i]}");
        }

        for (int i = 1; i < 10; i++){
            Console.WriteLine($"Indice : {i}",i);
        }
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
        char numeroChar = '1';
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

        string paragrafo = texto1 + " " + texto2 + true + " " + 8;
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
        string diaemPortuguesFormatada = dia.ToString("d MM yyyy", new CultureInfo("pt-BR"));
        string diaemPortuguesFormatadas = dia.ToString("dd/MMM/yyyy", new CultureInfo("pt-BR"));
        DateTime dia1 = new DateTime(2023, 12, 1, 20, 06, 1);
        DateTime hoje = DateTime.Today;
        DateTime hojeUtc = DateTime.UtcNow;
        DateTime novoDia = hojeUtc.AddDays(1);
        //object minhaVariavelObject = new Carro();
        int? idade = null;
        bool informouIdade = idade.HasValue;

        int[,] inteiros = new int[10, 10];
        inteiros[0, 0] = 1;
        inteiros[0, 3] = 2;

        Console.WriteLine(inteiros[0, 0]);
        Console.WriteLine(inteiros[0, 1]);
        Console.WriteLine(inteiros[0, 2]);
        Console.WriteLine(inteiros[0, 3]);

        List<int> listaInterios = new List<int>();
        listaInterios.Add(1);
        listaInterios.Add(2);
        listaInterios.Add(3);
        listaInterios.Add(4);
        listaInterios.Add(5);
        listaInterios.Remove(3);
        int primeiroElemento = listaInterios.First();
        int ultimoElemento = listaInterios.Last();
        int elementoSeleccionado = listaInterios.ElementAt(2);
        listaInterios.RemoveAt(3);
        // limpar a lista  
        listaInterios.Clear();
        OperacoesMatematicas operacoesMatematicas = new OperacoesMatematicas();
        var carro = new Carro("Ferrari")
        {
            Cor = Cor.Branco,
            LancadoEm = new DateOnly(2022, 12, 12)
        };

        var carro2 = new Carro("Porche")
        {
            Cor = Cor.Preto,
            LancadoEm = new DateOnly(2022, 12, 12)
        }

        ;
        carro.NomeDoModelo();
        carro2.NomeDoModelo();

        var resultadoSomaOperacao = operacoesMatematicas.sumar(1, 23);
        var resultadoSustracaoOperacao = operacoesMatematicas.subtrair(1, 2);
        (string autor, int resultado) = operacoesMatematicas.sumar(1, 2);
        (string autorSustracao, int resultadoSustracaoFinal) = operacoesMatematicas.subtrair(1, 2);
        operacoesMatematicas.multiplicar(1, autor: "Edmilson Junger");
        Console.WriteLine(resultadoSomaOperacao);
        Console.WriteLine(resultadoSustracaoOperacao);
        Console.WriteLine(resultadoSomaOperacao.Item1);
        Console.WriteLine(resultadoSomaOperacao.Item2);
        Console.WriteLine(resultadoSustracaoOperacao.Item1);
        Console.WriteLine(resultadoSustracaoOperacao.Item2);
        Console.WriteLine(resultadoSomaOperacao.autorSoma);
        Console.WriteLine(resultadoSomaOperacao.resultadoSomaFinal);
        Console.WriteLine(resultadoSustracaoOperacao.autorSustracao);
        Console.WriteLine(resultadoSustracaoOperacao.resultadoSustracaoFinal);
        Console.WriteLine(autor);
        Console.WriteLine(resultado);
        Console.WriteLine(autorSustracao);
        Console.WriteLine(resultadoSustracaoFinal);



        List<string> listaString = new List<string>();
        listaString.Add("A");
        listaString.Add("B");
        listaString.Add("C");
        string result = string.Join(" ", listaString);

        List<decimal> listaDecimais = new List<decimal>();
        listaDecimais.Add(1.1m);
        listaDecimais.Add(2.2m);
        listaDecimais.Add(3.3m);

        List<bool> listaBoolean = new List<bool>();
        listaBoolean.Add(true);
        listaBoolean.Add(false);
        listaBoolean.Add(true);
        List<object> listaObjetos = new List<object>();
        listaObjetos.Add(1);
        listaObjetos.Add("A");
        // listaObjetos.Add(new Carro());
        Dictionary<int, string> dicionario = new Dictionary<int, string>();
        dicionario.Add(1, "A");
        dicionario.Add(2, "B");
        dicionario.Add(3, "C");
        string elemento = dicionario[1];
        dicionario.Remove(1);
        //dicionario.Clear();
        string valueDicionario = dicionario[2];
        bool existeDicionario = dicionario.ContainsKey(1);
        HashSet<int> hashSet = new HashSet<int>();
        hashSet.Add(1);
        hashSet.Add(2);
        hashSet.Add(3);
        hashSet.Add(4);
        hashSet.Remove(3);
        hashSet.Clear();

        Console.WriteLine(hashSet.Count);
        Console.WriteLine(existeDicionario);
        Console.WriteLine(valueDicionario);
        Console.WriteLine(dicionario);
        Console.WriteLine(listaObjetos.Count);
        Console.WriteLine(listaString);
        Console.WriteLine(listaDecimais);
        Console.WriteLine(listaBoolean);

        Console.WriteLine("Hola", elementoSeleccionado);

        Console.WriteLine(listaInterios.Count);
        Console.WriteLine(listaInterios[0]);
        Console.WriteLine(listaInterios[1]);
        Console.WriteLine(listaInterios[2]);
        Console.WriteLine(listaInterios[3]);
        Console.WriteLine(listaInterios[4]);
        Console.WriteLine(primeiroElemento);
        Console.WriteLine(ultimoElemento);




        Console.WriteLine(numero);

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
        /*Carro meuCarro = new Carro();
        meuCarro.ligar();
        meuCarro.desligar();
        meuCarro.Teste2();*/

        Biscoito meuBiscoito = new Biscoito();
        meuBiscoito.Temperatura();
    }
}