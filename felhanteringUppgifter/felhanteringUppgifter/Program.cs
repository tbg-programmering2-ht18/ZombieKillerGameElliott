using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace felhanteringUppgifter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Ange din inkomst: ");
                    string inkomst = Console.ReadLine();
                    // if answer = 70kr
                    int n;
                    for (int i = 0; i <=inkomst.Length; i++)
                    {
                        string s = inkomst[i].ToString();
                        bool isNumeric = int.TryParse(s, out n);
                        if(isNumeric == true)
                        {
                            
                        }
                        else if(isNumeric == false)
                        {
                            string endOfnumbers = s;
                            break;
                        }
                        
                    }
                    inkomst.RemoveAt(s -> end)


                }

                catch (FormatException)
                {
                    Console.WriteLine("please write a numerical answer");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("No write zero");
                }

                // another one

                try
                {
                    // Placera kod här som KAN ge ett oväntat undantag
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
                finally
                {
                    // Om något går fel så hamnar vi till sist alltid här
                }

                Console.ReadLine();
                Console.Clear();

            }

        }
    }
}
