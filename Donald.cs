/**************************************************
 * Übungsnr:        04                                     
 * Programmname:    Donald&Friends                                  
 * Autor:           karlof002                                
 * ------------------------------------------------ 
 * Kurzbeschreibung:      
 * Wer bin ich? Über "intelligent" gestellte Fragen
 * soll erraten werden, welche Figur sich der Benutzer
 * ausgesucht hat! 
 * 
 * ************************************************
*/
using System;

namespace Donald
{
    class Donald
    {
        public static void Main(string[] args)
        {
            char antw;

            Console.WriteLine("Wer bist du? Darf ich versuchen, es herauszufinden?");

            Console.Write("Hmmm ... bist du ein Hund? (J/N)");
            antw = Convert.ToChar(Console.ReadLine());
            if (antw == 'J')  
            {
                //Es gibt nur einen Hund -> Goofy
                Console.WriteLine("Hallo  G O O F Y ! ! !");
            }
            else
            {
                //Kein Hund... dann unterscheiden ob Maus oder Ente...
                Console.Write("Dann vielleicht eine Maus? (J/N)");
                antw = Convert.ToChar(Console.ReadLine());
                if (antw == 'J')
                {
                    //Maus kann nur eine sein nämlich Mickey...
                    Console.WriteLine("Grüß dich,  M I C K E Y ! ! !");
                }
                else
                {
                    Console.WriteLine("Oh, eine Ente ...");
                    //Bei Enten sind drei Figuren möglich... Weiterfragen!
                    Console.Write("Bist du ein Kind? (J/N)");
                    antw = Convert.ToChar(Console.ReadLine());
                    if (antw == 'J')
                    {
                        //Ein Kind... dann kann es nur einer von Tick, Trick oder Track sein! (Genügt als Antwort!)
                        Console.WriteLine("Dann bist du einer von,  T I C K ,   T R I C K   o d e r   T R A C K ! ! !");
                    }
                    else
                    {
                        Console.Write("Nein? Dann also Erwachsen ... Bist du reich? (J/N)");
                        //Bleibt nur Dagobert oder Donald... = Reich oder Arm
                        antw = Convert.ToChar(Console.ReadLine());
                        if (antw == 'J')
                        {
                            Console.WriteLine("Meine Hochachtung,  O N K E L   D A G O B E R T  ! ! !");
                        }
                        else
                        {
                            Console.WriteLine("Servus,  O N K E L   D O N A L D  ! ! !");
                        }
                    }
                }
            }
        }
    }
}
