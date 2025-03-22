Console.Clear();
double numero1, numero2;
double resultado;

Console.WriteLine("insira numero aleatorio:");
    numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("insira numero aleatorio:");
    numero2 = Convert.ToInt32(Console.ReadLine());


resultado = numero1 * numero2;

Console.WriteLine();

Console.WriteLine("Resultado:");
    Console.WriteLine($"{numero1} * {numero2} = {resultado:N5}");

