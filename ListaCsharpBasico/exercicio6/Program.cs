Console.Write("Digite o Nº do funcionario: ");
string numeroString = Console.ReadLine();
int numero = int.Parse(numeroString);

Console.Write("Digite a qtd de horas trabalhadas: ");
string horasString = Console.ReadLine();
int horas = int.Parse(horasString);

Console.Write("Digite o valor da hora: ");
string valorHoraString = Console.ReadLine();
double valorhora = double.Parse(valorHoraString);

double salario = horas * valorhora;
string salarioString = salario.ToString("0.00");
Console.WriteLine($"Funcionario Nº: {numero}");
Console.WriteLine($"Salario: R$ {salarioString}");

