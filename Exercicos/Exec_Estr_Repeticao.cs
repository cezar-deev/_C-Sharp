//-------------------------------ESTRUTURA DE REPETIÇÃO : DO WHILE -------------------------------------


	public static void Main()
	{
		int ano = 0;
		double salario = 1700;
		do
		{
			salario += 50;
			ano++;
		} 
		while (ano < 3);
		Console.WriteLine(salario);
				
	}
}

//-------------------------------- WHILE ------------------------------------

string[] marcas = {"Coca-cola", "Pepsi", "Tobi", "Convenção"};
int i = 0;

while(i < marcas.Length)
	{
	Console.WriteLine(marcas[i]);
	i++;
	}


//-------------------------------- USANDO FOR ------------------------------------

using System;
					
public class Program
{
	public static void Main()
	{
		string [] series = {"The Boys", "Stranger Things", "100 dias de Dev", "Supernatural", "The Office"};   
		for (int i = 0; i < series.Length ; i++)
        {
           Console.WriteLine(series[i]);
        }
	}
}

//-------------------------------- USANDO FOR ------------------------------------

using System;
					
public class Program
{
	public static void Main()		
	{
		int pontos = 20;
		for (int rodada = 12 ; rodada<=30; rodada++)
		{
			pontos += 3 ;
		}		
		
		Console.WriteLine(pontos);
	}
}



