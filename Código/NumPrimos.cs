/* Código feito com o intuito de testar conhecimentos e ir apromorando estrutura entre outros */
using System;
class Código{
    static void Main(){
        string resp1, resp2;
        int numtest;

        Console.WriteLine("Esse programa vai mostrar para você se o número escolhido é primo ou não, vamos nessa?");
        resp1 = Console.ReadLine();

        reinício:

        Console.WriteLine("Qual número você deseja testar? (Somente números inteiros)");
        numtest = int.Parse(Console.ReadLine());
        Console.WriteLine("Deseja que o programe que prove o porque do resultado?[Sim / Nao]");
        resp2 = Console.ReadLine();

        switch(resp2){
            case "Não":
            case "não":
            case "nao":
            case "Nao":
            if(numtest == 1 | numtest == 2){    
                Console.WriteLine("O número {0} é um número primo pois so divide por ele mesmo e 1!", numtest);
            }else{
                
            }
            case "Sim":
            case "sim":
        
        }

        Console.WriteLine("Deseja testar outro número?");
        resp2 = Console.ReadLine();

        if(resp2 == "Não" || resp2 == "não" || resp2 == "nao" || resp2 == "Nao"){
            Console.Clear();
            goto reinício;
        }else{
            Console.WriteLine("Fim do programa, obrigado por testar!");
        }
    }
}