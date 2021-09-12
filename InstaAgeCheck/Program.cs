﻿using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //program küsib kasutaja vanust.
            //programm kontorllib, kas kasutaja on vanem või 13 aastat vana.
            //kui kasutaja on 13 aastat vana või vanem, siis ta võib Instagram'i kasutada.
            //kui kasutaja on noorem, kui 13, siis ta on liiga noor.

            Console.WriteLine("Palun sisesta enda vanus:");
            int UserAge = Convert.ToInt32(Console.ReadLine());

            if(UserAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagram'i kontot luua.");
            }
            else if(UserAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagram'i kontot luua.");
            }
            else
            {
                Console.WriteLine("Oledki 13, nüüd saad enda Instagram'i konto luua.");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
