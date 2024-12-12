/* Código feito com o intuito de testar conhecimentos e ir apromorando estrutura entre outros */
using System;
class Código{
    static void Main(){
        string resp1, resp2;
        int numtest, div;

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
                div = 2;
                int resto = 0;
                resto = numtest % div;
                for(div = 2;resto != 0 && div < numtest; div++){ //Aqui o programa vai usar um tetador, div, para dividir o numero em todas as possibilidades ate que o resto de 0 ou chegue a ele mesmo
                    resto = numtest % div;
                }
                if(resto == 0){
                    Console.WriteLine("O número {0} não é um número Primo, porque seu menor divisor é {1}",numtest ,div);
                }
                if(resto != 0){
                    Console.WriteLine("O número {0} é um número Primo, porque não divide por outro alem dele mesmo e 1",numtest);
                }
            }
            break;

            case "Sim":
            case "sim":
            if(numtest == 1 | numtest == 2){    
                Console.WriteLine("O número {0} é um número primo pois so divide por ele mesmo e 1!", numtest);
            }else{
                div = 2;
                int resto = 0;
                resto = numtest % div;
                for(div = 2;resto != 0 && div < numtest; div++){
                    resto = numtest % div;
                    Console.WriteLine("A divisão de {0} por {1} da resto: {2}", numtest, div, resto); //Aqui ele comprova os valores e porque é ou não é primo
                }
                if(resto == 0){
                    Console.WriteLine("O número {0} não é um número Primo, porque seu menor divisor é {1}",numtest ,div-1);
                }
                if(resto != 0){
                    Console.WriteLine("O número {0} é um número Primo, porque não divide por outro alem dele mesmo e 1",numtest);
                }
            }
            break;
        
        }

        Console.WriteLine("Deseja testar outro número?");
        resp2 = Console.ReadLine();

        if(resp2 == "Sim" || resp2 == "sim"){
            Console.Clear();
            goto reinício;
        }else{
            Console.WriteLine("Fim do programa, obrigado por testar!");
        }
    }
}