using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        public static void Main(string[] args)
        {
            string word;
            int l;

            Console.WriteLine("Ingrese la frase o cancion:");
            word = Console.ReadLine();

            word = word.ToLower();

            string[] lyrics = word.Split(' ');

            for (int i = 0; i < lyrics.Length; i++)
            {
                l = 1;


                for (int j = i + 1; j < lyrics.Length; j++)
                {
                    if (lyrics[i].Equals(lyrics[j]))
                    {
                        l++;

                        lyrics[j] = "0";




                        if (l > 1 && lyrics[i] != "0")
                            Console.WriteLine("Palabras repetidas:"); 
                            Console.WriteLine(lyrics[i]);

                    
                        
                    }

                   
                }


            }

        
        }
    }
}
