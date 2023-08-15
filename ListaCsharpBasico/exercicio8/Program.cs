Console.Write("Digite a 1ª Nota: ");
string nota1String = Console.ReadLine();
double nota1 = double.Parse(nota1String);

Console.Write("Digite a 2ª Nota: ");
string nota2String = Console.ReadLine();
double nota2 = double.Parse(nota2String);

Console.Write("Digite a 3ª Nota: ");
string nota3String = Console.ReadLine();
double nota3 = double.Parse(nota3String);

double media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5 )) / 10;
string mediaString = media.ToString("0.00");

Console.WriteLine($"A média do aluno é: {mediaString}");

