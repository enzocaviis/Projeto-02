string msg1 = "Bem-vindo ao sorteador para a mega-sena";
int indice;

try
{

    Random randon = new();

    do
    {

        Console.WriteLine(msg1);

        Console.Write("Informe a quantidade de numeros que serão sorteados (de 6 a 15): ");
        int quantidadenum = int.Parse(Console.ReadLine());

        while (quantidadenum < 6 || quantidadenum > 15)
        {
            Console.WriteLine("Obs: de 6 a 15");
            Console.Write($"O numero {quantidadenum} não corresponde ao predicado (6 a 15), informe novamente: ");
            quantidadenum = int.Parse(Console.ReadLine());
        }

        HashSet<int> valores = [];

        Console.WriteLine("Numeros sorteados:");

        while (valores.Count < quantidadenum)
        {
            valores.Add(randon.Next(1, 61));
        }

        int contador = 0;

        foreach (int valor in valores.OrderBy(n => n))
        {
            contador++;
            Console.WriteLine($"{contador}- {valor}");
        }

        msg1 = "Ola denovo!";
        Console.Write($"\nPara fazer um novo sorteio digite 1, para finalizar digite 2:\n1-Novo sorteio\n2-Finalizar\nOpção: ");
        indice = int.Parse(Console.ReadLine());

        while (indice < 1 || indice > 2)
        {
            Console.Write($"\nO numero {indice} não corresponde a 1 ou a 2, informe novamente: ");
            indice = int.Parse(Console.ReadLine());
        }

    } while (indice == 1);

    Console.WriteLine("Tudo bem, até a proxima");

}
catch (Exception ex)
{
    Console.WriteLine($"A informação recebida é invalida\nErro: {ex.Message}");
}