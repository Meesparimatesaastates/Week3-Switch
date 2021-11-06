using System;

namespace PersonalityTestSwitch
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
            string userColor = Console.ReadLine().ToLower();
            //Punane, Sinine, Roheline
            switch(userColor)
            {
                case "punane": //if(userColor =="Punane")
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas");
                    break;
                case "roheline":
                    Console.WriteLine("Oled loodussõber");
                    break;
                default:
                    Console.WriteLine($"Sa Oled{userColor} ükssarvik");
                    break;
         
            }
            Console.WriteLine("Kena päeva");
        }


    }
}
