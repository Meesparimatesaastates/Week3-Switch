using System;

namespace Personality_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tema lemik värv;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine" konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline" siis konsool kuvab "oled looduse sõber";
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "oled {userColor} ükssarvik";
            Console.WriteLine("Sisesta oma lemmikvärv");
            string userColor = Console.ReadLine();
            if (userColor == "punane")
            {
                Console.WriteLine("oled romantiline");
            }
            else if (userColor == "sinine")
            { Console.WriteLine("oled töökas"); }
            else if (userColor =="roheline")
            { Console.WriteLine("oled looduse sõber"); }
            else { Console.WriteLine($"oled {userColor} ükssarvik"); }
            Console.WriteLine("Kena päeva");

        }
    }
}
