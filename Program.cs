using System.Globalization;

int opcao = 0;
Console.Title = "Exercicios";
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Yellow;
do
{
    
    Console.Clear();
    Console.WriteLine("Selecione um exercício de 1 a 7, e 0 para sair.");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Exercicio 01 ");
            ex01();
            pause();
            break;

        case 2:
            Console.WriteLine("Exercicio 02 ");
            ex02();
            pause();
            break;

        case 3:
            Console.WriteLine("Exercicio 03 ");
            ex03();
            pause();
            break;

        case 4:
            Console.WriteLine("Exercicio 04 ");
            Ex04();
            pause();
            break;

        case 5:
            Console.WriteLine("Exercício 05 ");
            ex05();
            pause();
            break;

        case 6:
            Console.WriteLine("Exercicio 06 ");
            ex06();
            pause();
            break;

        case 7:
            Console.WriteLine("Exercicio 07 ");
            ex07();
            pause();
            break;

        default:
            Console.WriteLine("Opção inválida");
            pause();
            break;

    }
}while(opcao != 0); ;



/* Exercicio 01
  Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.*/

static void ex01()
{
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("Saída: ");
    if(x >= 1 && x<= 100)
    {
        for(int i = 1; i <= x;i++)
        {
            if(i % 2 != 0)
            {
                Console.WriteLine( i);
            }
        }
    }
}

/*
 Exercicio 02
Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo);

*/

static void ex02()
{
    int x = int.Parse(Console.ReadLine());
    int y = 0;
    int IN = 0;
    int OUT = 0;

    for(int i = 1;i <= x;i++)
    {
        y = int.Parse(Console.ReadLine());
        if(y >= 10 && y >= 20)
        {
        IN++;
        }
        else
        {
            OUT++;
        }
    }

    Console.WriteLine("Saída");
    Console.WriteLine($"{IN} in\n{OUT} out");
}

/* Exercicio 03
 Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste 
de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes 
conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem 
peso 5.
 */

static void ex03()
{
    int x = int.Parse(Console.ReadLine());
    string[] num = new string[3];
    for (int i = 0; i < x; i++)
    {
        num = Console.ReadLine().Split(' ');
        double a = double.Parse(num[0],CultureInfo.InvariantCulture);
        double b = double.Parse(num[1],CultureInfo.InvariantCulture);
        double c = double.Parse(num[2],CultureInfo.InvariantCulture);

        double m = ((a*2) + (b*3) + (c*5)) / 10;
        Console.Write("Saida: ");
        Console.WriteLine(m.ToString("N1",CultureInfo.InvariantCulture));
    }
    
}

/* Exercicio 04
 Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo 
segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
 */

static void Ex04()
{
    int x = int.Parse(Console.ReadLine());
    double a, b, r;
    for (int i = 0; i < x; i++)
    {
        string[] numeros = Console.ReadLine().Split(" ");
        a = double.Parse(numeros[0]);
        b = double.Parse(numeros[1]);
        Console.Write("Saida: ");
        if (b != 0)
        {
            r = a / b;
            Console.WriteLine(r.ToString("N1", CultureInfo.InvariantCulture));
        }
        else
        {
            Console.WriteLine("divisão impossível.");
        }
    }

    Console.ReadKey();
}

/* Exercicio 05
 Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
Lembrando que, por definição, fatorial de 0 é 1.
 */

static void ex05()
{
    int x = int.Parse(Console.ReadLine());
    int fat = 1;
    for (int i = 1; i <= x; i++)
    {
        fat = fat * i;        
    }
    Console.Write("Saida: ");
    Console.WriteLine(fat);
}

static void ex06()
{
    int n = int.Parse(Console.ReadLine());
    Console.Write("Saida: ");
    for (int i = 1; i <= n; i++)
    {
        if(n % i == 0)
        {
            Console.WriteLine(i);
        }
    }
}

static void ex07()
{
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("Saida: ");
    for (int i = 1; i<= n; i++)
    {       
        Console.WriteLine($"{i} {Math.Pow(i,2)} {Math.Pow(i,3)}");
    }
}


static void pause()
{
    Console.WriteLine("Pressione [enter] para continuar");
    Console.ReadKey();
}


