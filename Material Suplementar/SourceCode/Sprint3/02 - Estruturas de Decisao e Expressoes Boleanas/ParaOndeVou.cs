using System;

namespace ParaOndeVou {
    class Program {
        static void Main (string[] args) {
            
            String passeio = "montanha";

            switch (passeio) {
                case "montanha":
                    Console.WriteLine ("Bora escalar!");
                    break;
                case "deserto":
                    Console.WriteLine ("Leva uma água!");
                    break;
                case "floresta":
                    Console.WriteLine ("Vai lá, Tarzan");
                    break;
                case "mar":
                    Console.WriteLine ("Compra uma bóia!");
                    break;
                default:
                    Console.WriteLine ("Ah, bora assistir Netflix");
                    break;
            }

        }
    }
}