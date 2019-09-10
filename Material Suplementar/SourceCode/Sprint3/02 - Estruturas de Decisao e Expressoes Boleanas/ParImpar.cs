using System;

class ParImpar {
    static void Main (string[] args) {

        //Declarando as variáveis necessárias
        int numeroMaquina = 0;
        int numeroUsuario = 0;
        String escolhaUsuario = "";
        String respostaUsuario = "";

        // Preparando para receber o input do teclado
        Console.WriteLine ("Olá! Gostaria de jogar par ou ímpar?");
        respostaUsuario = Console.ReadLine();
        // 1) Caso a resposta do usuário for igual à palavra "Sim", começar o jogo
        if (respostaUsuario.Equals("Sim", StringComparison.InvariantCultureIgnoreCase)) {

            Console.WriteLine ("Ótimo! Vamos lá!");

            // 3) Apenas recupera e limpa o conteúdo da resposta do usuário, pois já sabemos o que precisamos
            //respostaUsuario = Console.ReadLine();

            Console.WriteLine ("Você quer PAR ou IMPAR?");

            // 4) agora nos interessa guardar a reposta em uma variável, porque precisamos saber se ele escolheu PAR ou IMPAR mais
            // à frente no nosso programa
            escolhaUsuario = Console.ReadLine();

            // 5) Verificamos se, independente de maiúsculas e minúsculas graças ao método "equalsIgnoreCase", o usuário
            // escolheu PAR e exibimos uma mensagem da máquina de acordo com a escolha
            // FIXME - Notem que aqui eu não verifico se o usuário escreveu qualquer outra coisa!
            if (escolhaUsuario.Equals("par", StringComparison.InvariantCultureIgnoreCase)) {
                Console.WriteLine ("Vou de IMPAR então");
            } else {
                Console.WriteLine ("Vou de PAR então");
            }

            Console.WriteLine ("Escolha um número de 0 até 10");
            respostaUsuario = Console.ReadLine();

            // 6) Se a resposta do usuário contiver um int, prossiga
            // FIXME - Note que eu não valido se o número digitado realmente está entre 0 e 10
            if (int.TryParse(respostaUsuario, out numeroUsuario)) {

                // 8) Recupero a resposta do usuário no console

                Console.WriteLine ("Você escolheu: " + numeroUsuario);
                Console.WriteLine ("Vou escolher o meu...");

                // 9) Peço à máquina que gere um número aleatório de 0 a 10 para si
                Random rand = new Random();
                numeroMaquina = rand.Next(0,10);

                // 10) Peço para que o processamento espere 1 segundo (está em milisegundos)
                //Thread.sleep (1000);

                Console.WriteLine ("Ok! Escolhi o " + numeroMaquina);

                /* 11) Valido se:
                    * 	a) 
                    *     a soma do numeroUsuario com numeroMaquina divididos com o operador de módulo pelo número 2 é igual a 0 (caso de número par)
                    * 														E
                    * 										vejo o usuario escolheu a opção PAR
                    *  b) exibo a mensagem adequada
                    */
                if ((numeroUsuario + numeroMaquina) % 2 == 0 && escolhaUsuario.Equals ("PAR", StringComparison.CurrentCultureIgnoreCase)) {
                    Console.WriteLine ("Você venceu!");

                    /* 12) Caso um dos testes dê "false", passo a validar se:
                        * 	a) 
                        *     a soma do numeroUsuario com numeroMaquina divididos com o operador de módulo pelo número 2 é diferente de 0 (caso de número ímpar)
                        * 														E
                        * 										vejo o usuario escolheu a opção IMPAR
                        *  b) exibo a mensagem adequada
                        */
                } else if ((numeroUsuario + numeroMaquina) % 2 != 0 && escolhaUsuario.Equals("IMPAR", StringComparison.CurrentCultureIgnoreCase)) {
                    Console.WriteLine ("Você venceu!");

                    /* 13) Caso o resultado dos condicionais todos acima retornem false, significa que o usuário perdeu, então somente exibo a mensagem adequada
                        */
                } else {
                    Console.WriteLine ("Venci!");
                }

                // 7) Se a resposta do usuário não contiver um int, exiba a mensagem adequada
            } else {
                Console.WriteLine ("Você não sabe brincar...");
            }

            // 2) Caso a resposta dele seja algo diferente, cancele o programa
        } else {
            Console.WriteLine ("Que pena! Atê mais!");
        }

    }
}