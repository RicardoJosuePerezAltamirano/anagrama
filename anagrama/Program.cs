using System;
using System.Collections.Generic;

namespace anagrama
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra = "perro";
            List<string> palabras = new List<string>();
            var caracteres = palabra.ToCharArray();
            
                string nueva = "";
            for(int i=0;i<caracteres.Length;i++)
            {
                List<string> letras = new List<string>();
                for (int x = 0; x < caracteres.Length; x++)
                {
                    letras.Add(caracteres[x].ToString());
                }
                string inicial = "";
                if(i==caracteres.Length-1)
                {
                    inicial = $"{letras[0]}";
                }
                else
                {
                    inicial = $"{letras[i + 1]}";
                }
                
                string final = $"{letras[i]}";
                //Console.WriteLine(caracteres);
                letras.Remove(inicial);
                letras.Remove(final);
                var palaux = "";
                foreach(var l in letras)
                {
                    palaux += l;
                }
                nueva = inicial + palaux + final;
                palabras.Add(nueva);

            }
            foreach(var p in palabras)
            {
                Console.WriteLine(p);
            }


            //string[] words = new string[] { "big", "bad", "dog" };
            //for (int mask = 0; mask < 1 << (words.Length); mask++)
            //{
            //    string permutation = "";
            //    for (int i = 0; i < words.Length; i++)
            //    {
            //        if ((mask & (1 << (words.Length - 1 - i))) != 0)
            //        {
            //            permutation += words[i] + " ";
            //        }
            //    }
            //    Console.WriteLine(permutation);
            //}


        }
    }
}
