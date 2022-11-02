Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("--- Mês por extenso ---\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Digite o número do mês: ");
int mes = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

string mesExtenso;

switch (mes)
{
    case 1:
        mesExtenso = "Janeiro";
        break;
    case 2:
        mesExtenso = "Fevereiro";
        break;
    case 3:
        mesExtenso = "Março";
        break;
    case 4:
        mesExtenso = "Abril";
        break;
    case 5:
        mesExtenso = "Maio";
        break;
    case 6:
        mesExtenso = "Junho";
        break;
    case 7:
        mesExtenso = "Julho";
        break;
    case 8:
        mesExtenso = "Agosto";
        break;
    case 9:
        mesExtenso = "Setembro";
        break;
    case 10:
        mesExtenso = "Outubro";
        break;
    case 11:
        mesExtenso = "Novembro";
        break;
    case 12:
        mesExtenso = "Dezembro";
        break;
    default:
        mesExtenso = "Mês inválido.";
        break;
}

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine();
Console.WriteLine(mesExtenso);
Console.ResetColor();