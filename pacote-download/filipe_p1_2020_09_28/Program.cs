using System;

namespace filipe_p1_2020_09_28
{
    class Program
    {
        static void Main(string[] args)
        {   
            int opcao;
            do
            {
                Console.WriteLine("Proporção padrão para piscinas (4 gramas de cloro para cada 1000 litros de água).");

                Console.Write("O que deseja calcular, caixa d'água ou piscina? ");
                string compartimento = Console.ReadLine();

                Console.Write("Informe a quantidade de água em litros...: ");
                double quantidadeAguaLitros = double.Parse(Console.ReadLine());

                if (quantidadeAguaLitros < 10)
                    Console.WriteLine("Valor muito baixo para ser calculado.");
                else {
                    double quantidadeCloroSerUsado = quantidadeAguaLitros * 4 / 1000;

                    Console.WriteLine("A quantidade de cloro a ser usada é...: {0:n2} gramas de cloro.", quantidadeCloroSerUsado);

                    Console.WriteLine("para sua " + compartimento);
                }
                Console.Write("1 - novo cálculo\nPressione qualquer tecla para sair: ");
                    opcao = int.Parse(Console.ReadLine());      
            }
            while (opcao == 1);            

            Console.ReadKey();            
        }
    }
}
