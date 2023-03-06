using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //когда систсетме независит от способа создания и компановки новых обьектов 
            //
            // Когда создаваемые обьекты должны использоватся в месте
            // 
            // Необходим если кокойто обьект характеризуется определённым комплексом признаков 

            // Но комплексы и меют как разные так и одинаковые признаки

            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Hero voin = new Hero(new VoinFactory());
            voin.Hit();
            voin.Run();

            Console.ReadLine();
        }
    }
}
