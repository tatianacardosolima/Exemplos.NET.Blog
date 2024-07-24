
using System.Text;

Console.WriteLine("Use interpolação de strings");
var nome = "Tatiana";
var sobrenome = "Lima";
Console.WriteLine($"O nome do cliente é {nome} {sobrenome}.");

Console.ReadLine();
Console.Clear();

Console.WriteLine("Use @ para preservar espaços, tabulações e quebra de linhas e para representar os caminhos de arquivos em strings:");
var urlCanal = "https://canaldeatendimento.com";
Console.WriteLine(@$"Prezado(a), {nome} {sobrenome}.
                Ficamos muito feliz em poder atendé-lo. 
                Para estreitar nosssos lados criamos este canal {urlCanal}, 
                aqui você poderá entrar em contato e tirar todas as suas dúvidas.");

Console.ReadLine();
Console.Clear();

Console.WriteLine("Use @ para simplificar nomes de pastas:");
var path = "c:\\teste\\caminho\\do\\arquivo.txt";
var path2 = @"c:\teste\caminho\do\arquivo.txt";

Console.WriteLine(@$"Caminho 1: {path}
Caminho 2: {path2}.");

Console.ReadLine();
Console.Clear();

string mensagem = "Esse texto será convertido em um array de Bytes e depois convertido em string";
byte[] conteudo = System.Text.Encoding.Unicode.GetBytes(mensagem);
string unicodeString = Encoding.Unicode.GetString(conteudo, 0, conteudo.Length);
Console.WriteLine($"unicodeString= {unicodeString}");


Console.ReadLine();
Console.Clear();

string listadecompras = "arroz, feijão;carne;batata, queijo, leite";
string[] lista = listadecompras.Split(", ");

foreach (string palavra in lista)
{
        Console.WriteLine(palavra);
}

Console.WriteLine("------------");
string[] lista2 = listadecompras.Split(new char []{ ',', ';' });

foreach (string palavra in lista2)
{
    Console.WriteLine(palavra.Trim());
}

Console.ReadLine();
Console.Clear();

var endereço = string.Empty;
if (string.IsNullOrEmpty(endereço))
{
    Console.WriteLine("Favor informar o endereço!");
}

Console.ReadLine();
Console.Clear();

DateTime agora = DateTime.Now;
string dtStr = String.Format("{0:d} às {0:t}", agora);
decimal preço = 4.49m;
string preçoFormatado = String.Format("Combustível: {0, 0:C2}", preço);

Console.WriteLine(dtStr);
Console.WriteLine(preçoFormatado);

Console.ReadLine();
Console.Clear();


Person person = new Person();
person.Name = "Tatiana Lima";
person.Email = "tati@tati.com";
Console.WriteLine(person);

Console.ReadLine();
Console.Clear();
public class Person
{
    public string Name { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return $"{Name} e {Email}";
    }
}