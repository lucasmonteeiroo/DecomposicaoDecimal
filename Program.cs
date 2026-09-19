Console.Clear();
Console.WriteLine("--- Decomposição Decimal ---");


Console.Write("Digite um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());


int unidades = numero % 10;
int restante = numero / 10;


int dezenas = restante % 10;
restante = restante / 10;


int centenas = restante;


Console.WriteLine($"O número {numero} possui:");
Console.WriteLine($"Unidades: {unidades}");
Console.WriteLine($"Dezenas: {dezenas}");
Console.WriteLine($"Centenas: {centenas}");
