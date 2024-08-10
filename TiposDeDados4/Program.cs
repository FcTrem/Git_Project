Console.WriteLine("## struct  DataTime ##\n");

DateTime dataAtual = DateTime.Now;

// deu certo aqui 
DateTime data2 = new DateTime(2019, 11, 10,  12,23,32); 

Console.WriteLine(data2);

DateTime data3 = DateTime.Now;
Console.WriteLine(dataAtual);

Console.WriteLine("que dia e hoje?");




Console.WriteLine("ano  "+dataAtual.Year);
Console.WriteLine("hora "+ dataAtual.Hour);
Console.WriteLine("minutos "+ dataAtual.Minute);
Console.WriteLine("segundos "+dataAtual.Second);


DateTime hoje = DateTime.Now;

Console.WriteLine(hoje.AddYears(10) );
Console.WriteLine(hoje.AddDays(4));
Console.WriteLine(hoje.AddMonths(4));
Console.WriteLine(hoje.AddHours(4));
Console.WriteLine(hoje.AddSeconds);
Console.WriteLine(hoje.AddMilliseconds(30));



Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine("\n"+ hoje.ToShortDateString());  


/*
Console.WriteLine(hoje.ToShortTimeString());
Console.WriteLine(hoje.ToLongTimeString());

Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());
/*
Console.WriteLine("ano "+hoje.Year);
Console.WriteLine("mês "+hoje.Month);
Console.WriteLine("dia "+hoje.Day);
Console.WriteLine("hora "+hoje.Hour);
Console.WriteLine("minutos "+hoje.Minute);
Console.WriteLine("segundos "+hoje.Second);
Console.WriteLine("milliSegundos "+hoje.Millisecond);
*/

Console.WriteLine(hoje.Year - 3);
Console.WriteLine(hoje.Hour - 4);
DateTime novoAno = new DateTime(2011,2,7,   22, 59, 59);

int fi = 1;
string a = (hoje.ToLongDateString());
Type type = a.GetType();

Console.WriteLine(type);
