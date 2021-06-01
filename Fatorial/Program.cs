using System;

namespace Fatorial
{
    class Program
    {
        static int Main(string[] args)
        {


            try
            {
                var num = Convert.ToInt32(args[0]);
                
                

                if (num==0)
                {
                    Console.WriteLine($"O fatorial de {num} é 1");
                }
                else if (num < 0)
                {
                    Console.WriteLine("O número deve ser maior que 0.");
                }
                else
                {
                    double resultado = 1;
                    for (int i = num; i > 0; i--)
                    {
                        resultado *= i;
                    }
                    Console.WriteLine($"O fatorial de {num} é {resultado}");                    
                }

                return 0;
            }
            catch(FormatException)
            {
                Console.WriteLine($"{args[0]} não é um número.");
                return 1;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Por favor, digite um número entre 0 e {Int32.MaxValue}.");
                return 1;
            }
            catch (Exception)
            {
                Console.WriteLine("Um erro ocorreu, tente mais tarde.");
                return 1;                
            }
        }
    }
}
