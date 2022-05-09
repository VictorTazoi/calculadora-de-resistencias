using System;

namespace CR06092021
{
    class Program
    {
        static void Main(string[] args)
        {
            char loop_menu = 'y';
            while (loop_menu == 'y')
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\tCalculo de Resistência Necessária");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\t- - - - - - - - - - - - - - - - - - - - ");
                Console.WriteLine("\n\t1 - Calculo de resistência de componentes semelhantes em série");
                Console.WriteLine("\n\t2 - Calculo de resistência de componentes semelhantes em paralelo");
                Console.Write("\n\tSelecione: ");
                byte necessaria_option = byte.Parse(Console.ReadLine());
                if (necessaria_option == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\tCalculo de resistência de componentes semelhantes em série");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\t- - - - - - - - - - - - - - - - - - - - ");
                    Console.Write("\n\tTensão da fonte: ");
                    float tensao_fonte = float.Parse(Console.ReadLine());
                    Console.Write("\n\tTensão do componente: ");
                    float tensao_componente = float.Parse(Console.ReadLine());
                    Console.Write("\n\tCorrente do componente: ");
                    float corrente_componente = float.Parse(Console.ReadLine());
                    Console.Write("\n\tQuantidade de componentes: ");
                    int qtde_componente = int.Parse(Console.ReadLine());
                    Console.Clear();
                    float resistencia = (tensao_fonte - tensao_componente) / (corrente_componente * qtde_componente);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\tResistência necessária: {0}", resistencia);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                }
                else if (necessaria_option == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\tCalculo de resistência de componentes semelhantes em série");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\t- - - - - - - - - - - - - - - - - - - - ");
                    Console.Write("\n\tTensão da fonte: ");
                    float tensao_fonte = float.Parse(Console.ReadLine());
                    Console.Write("\n\tTensão do componente: ");
                    float tensao_componente = float.Parse(Console.ReadLine());
                    Console.Write("\n\tCorrente do componente: ");
                    float corrente_componente = float.Parse(Console.ReadLine());
                    Console.Write("\n\tQuantidade de componentes: ");
                    int qtde_componente = int.Parse(Console.ReadLine());
                    Console.Clear();
                    float resistencia = (tensao_fonte - (tensao_componente * qtde_componente)) / corrente_componente;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\tResistência necessária: {0}", resistencia);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\tDeseja voltar ao menu? y/n : ");
                loop_menu = char.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                if (loop_menu == 'n')
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\tTem certeza que deseja sair? y/n : ");
                    char confirm_exit = char.Parse(Console.ReadLine());
                    if (confirm_exit == 'y')
                    {
                        loop_menu = 'n';
                    }
                    else if (confirm_exit == 'n')
                    {
                        loop_menu = 'y';
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } 
        }
    }
}
