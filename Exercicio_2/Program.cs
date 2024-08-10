Console.WriteLine("Deseja Entrar no Mercado? true/false");
bool compra = Boolean.Parse(Console.ReadLine());

//Armazenamento De Variavels
bool respostaDoUsuario;
int uva_verde = 5;
int InputDaUva;

while (compra)
{
    if (compra)
    {
        Console.WriteLine("Deseja Comprar Quantas Uva Maximo 5:");
        InputDaUva = Convert.ToInt32(Console.ReadLine());
        
        if( InputDaUva < uva_verde)
        {
            Console.WriteLine("Você Comprou "+InputDaUva+" Agora Temos "+ (uva_verde - InputDaUva));
            break;
        }
        else if(InputDaUva == 5)
        {
            Console.WriteLine("Você Comprou todas as Uva Verde Mais Tarde Tera mais:");
            break;
        }

        else
        {
            Console.WriteLine();
        }
        
    }
}
/* Consideração Final do Código
 * Codigo Porco Cheio de gambiararr
 * Todo Baguçado
 * unica coisa talvez boa  foi  os comentario algo intendivel Mais nada Demais
 * indentação Pessima chega da vantande de vomitar
 */

Console.ReadLine();

