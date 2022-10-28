using System;  

class Program 
{
    public static void Main(string[] args)
    { 
        double etanol, gasolina, vantagem;
        String escolha = "1";
        while (escolha == "1")
        {
          Console.WriteLine("Informe o valor do Etanol em sua Cidade:");
            etanol = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da Gasolina em sua Cidade:");
            gasolina = double.Parse(Console.ReadLine());
            vantagem = etanol / gasolina;
            if (vantagem == 0.70)
              { 
                Console.WriteLine("Tanto faz abaster com Etanol ou Gasolina. ");
              } 
            else if (vantagem < 0.70)
              { 
                Console.WriteLine("Vale mais a pena abastecer com Etanol. ");
              } 
            else 
              { 
                Console.WriteLine("Vale a mais pena abastecer com Gasolina. ");
              } 
            Console.WriteLine("Deseja calcular novamente? Digite: 1 para [SIM] ou 2 para [NÃO].");
            escolha = Console.ReadLine();
          Console.Clear();
        } 
            if (escolha == "2")
              { 
                Console.WriteLine("Consulta realizada. Obrigado!");
               } 

    } 

} 





