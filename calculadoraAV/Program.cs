using System;
using System.Text.RegularExpressions;
namespace calculadoraAV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("");
            Console.WriteLine("Puedes realizar cualquier operacion basica y se te mostrara en pantalla la operacion y el resultado.");
            Console.WriteLine("");

            List<string> operation = new List<string>();
            List <int> resultI = new List<int>();
            string user;
            int resultII;

            while (true)
            {
                do
                {
                    Console.Write("Realiza la operacion que tu desees,");
                    Console.WriteLine(" si deseas finalizar en cualquier momento, escribe la palbra 'exit'");
                    user = Console.ReadLine();

                    if (user.ToLower() != "exit")
                    {
                        operation.Add(user);

                        var match = Regex.Match(user, @"(\d+)\s*([\+\-\*/])\s*(\d+)");
                        if (match.Success)
                        {
                            int num1 = int.Parse(match.Groups[1].Value);
                            char op = match.Groups[2].Value[0];
                            int num2 = int.Parse(match.Groups[3].Value);

                            while (user.ToLower() != "exit")
                            {
                                switch (op)
                                {
                                    case '+':
                                        resultII = (num1 + num2);
                                        resultI.Add(resultII);
                                        Console.WriteLine($"{num1}{op}{num2}={resultII}");
                                        Console.WriteLine("");
                                        break;
                                    case '-':
                                        resultII = (num1 - num2);
                                        resultI.Add(resultII);
                                        Console.WriteLine($"{num1}{op}{num2}={resultII}");
                                        Console.WriteLine("");
                                        break;
                                    case '*':
                                        resultII = (num1 * num2);
                                        resultI.Add(resultII);
                                        Console.WriteLine($"{num1}{op}{num2}={resultII}");
                                        Console.WriteLine("");
                                        break;
                                    case '/':
                                        resultII = (num1 / num2);
                                        resultI.Add(resultII);
                                        Console.WriteLine($"{num1}{op}{num2}={resultII}");
                                        Console.WriteLine("");
                                        break;
                                }
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Termino no valido");
                        }
                    }
                }
                while (user.ToLower() != "exit");
                {
                    Console.WriteLine("Operaciones ingresadas:");
                    foreach (var operacion in operation)
                    {
                        Console.WriteLine(operacion);
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Resultado:");
                    foreach (var r in resultI)
                    {
                        Console.WriteLine(r);
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("Si ya no deseas volver a ingresar operaciones, Preciona la tecla 'esc'");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Programa cerrado...");
                    break;
                }
            }
        }
    }
}