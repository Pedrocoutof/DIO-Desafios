
using System;
class MinhaClasse {
    public static void Main (string[] args) {
        var totalDeCasosDeTeste = int.Parse(Console.ReadLine()!);
        // Implemente a solução aqui
        
        
        string produtos;
        
        for(int i = 0 ; i < totalDeCasosDeTeste; i++)
        {
            List<String> lista = new List<string>();
            produtos = Console.ReadLine()!;

            string[] produtosEmOrdem;
            produtosEmOrdem = produtos.Split(" ");
                
            for (int j = 0; j < produtosEmOrdem.Count(); j++)
            {
                
                if (!lista.Contains(produtosEmOrdem[j]))
                {
                    lista.Add(produtosEmOrdem[j]);
                }
            }
            
            lista.Sort();
            Console.WriteLine("Lista ordenada:");
            for (int k = 0; k < lista.Count(); k++)
            {
                Console.Write($"{lista[k]} ");
            }
        }
    }
}