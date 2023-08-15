Console.Write("Digite a 1ª Nota: ");
string nota1String = Console.ReadLine();
double nota1 = double.Parse(nota1String);

Console.Write("Digite a 2ª Nota: ");
string nota2String = Console.ReadLine();
double nota2 = double.Parse(nota2String);

double media = ((nota1*3.5) + (nota2*7.5)) / 11;
string mediaString = media.ToString("0.00");

Console.WriteLine($"A média do aluno é: {mediaString}");

