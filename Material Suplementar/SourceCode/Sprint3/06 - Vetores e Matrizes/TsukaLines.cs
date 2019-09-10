using System;

namespace desafioArray {
    class Program {
        static void Main (string[] args) {
            int        resposta, cont = 0, contE = 0;
            int[]      numeroPassagens = new int[2];
            string[]   nomes = new string[2];
            DateTime[] datas = new DateTime[2];

            Console.WriteLine ("Tsukamoto AirLines");
            do {
                Console.WriteLine ("Escolha uma opção");
                Console.WriteLine ("1 - Agendar Vigem");
                Console.WriteLine ("2 - Exibir Viagens");
                Console.WriteLine ("0 - Sair");
                resposta = int.Parse (Console.ReadLine ());
                switch(resposta){
                    case 1:
                    //agendar viagem
                    if(cont < 2){
                        Console.WriteLine("Digite o nome do Passageiro");
                        nomes[cont] = Console.ReadLine();
                        Console.WriteLine("Digite o nº da passagem");
                        numeroPassagens[cont] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a data do Voo");
                        datas[cont] = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Passagem cadastrada com sucesso");                        
                        cont++;
                    }else{
                        Console.WriteLine("Limite excedido");
                    }
                    break;
                    case 2:
                        contE = 0;
                        while(contE < cont){
                        //Exibir Viagens
                        Console.WriteLine($"Passageiro Nº{contE+1}");
                        Console.WriteLine($"Nome: {nomes[contE]}");
                        Console.WriteLine($"Numero da passagem:{numeroPassagens[contE]}");
                        Console.WriteLine($"Data do Voo: {datas[contE]:dd-MMM-yyyy}");                       
                        contE++;
                        }


                    break;
                    case 0:
                        //finalizar programa
                     break;
                    default:
                        Console.WriteLine("Resposta Inválida");
                    break;
                }//fim switch
            } while (resposta != 0);

            Console.WriteLine ("A Tsukamoto AirLines Agradece");

        } //fim main
    }
}