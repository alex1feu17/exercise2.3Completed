using System;

namespace exercise2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string premiernombre = "";
            string deuxiemenombre = "";
            string symbole = "";
            int total = 0;

            Console.WriteLine("Quelle est votre premier nombre");
            premiernombre= Console.ReadLine();
            int nombre1 = Int32.Parse(premiernombre);

            Console.WriteLine("Quelle est votre deuxieme nombre");
            deuxiemenombre = Console.ReadLine();
            int nombre2 = Int32.Parse(deuxiemenombre);

            Console.WriteLine("Quelle est votre symbole d'equation ");
            symbole = Console.ReadLine();

            if(symbole=="+")
            {
                total = nombre1 + nombre2;
            }
            if (symbole == "-")
            {
                total = nombre1 - nombre2;
            }
            if (symbole == "*")
            {
                total = nombre1 * nombre2;
            }
            if (symbole == "/")
            {
                total = nombre1 / nombre2;
            }
            Console.WriteLine(total);
        }
    }
}
