double pi = 3.14159;

Console.Write("Digite o valor do raio da circunferência: ");
string raioString = Console.ReadLine();
double raio = double.Parse(raioString);

double area = pi * raio*raio;
Console.WriteLine("A área da circunferência é: " + area);