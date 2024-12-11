using System;
class Program
{
    static void Main()
    {
        string cFrase = "";

        Console.WriteLine("Primeiro nome:");
        string cFirstNome = Console.ReadLine();

        Console.WriteLine("Sobrenome(s):");
        string cLastNome = Console.ReadLine();

        if (!string.IsNullOrEmpty(cFirstNome) || !string.IsNullOrEmpty(cLastNome))
        {
            if (!string.IsNullOrEmpty(cFirstNome) && string.IsNullOrEmpty(cLastNome)) 
            {
                cFrase = "Seu nome é " + cFirstNome;    
            }

            else if (string.IsNullOrEmpty(cLastNome) && !string.IsNullOrEmpty(cLastNome)) 
            {
                cFrase = "Seu sobrenome é " + cLastNome;
               
            }

            else if (!string.IsNullOrEmpty(cLastNome) && !string.IsNullOrEmpty(cLastNome)) 
            {
                cFrase = "Seu nome completo é:" +$"{cFirstNome} {cLastNome}"; 
            }  

            Console.WriteLine(cFrase);      
        }
    }
}
