using System;

namespace BatteleGame
{
    internal class program
    {
        public static void main(string[] args)
        {
            // Variablen und Obijekte deklarieren
            Spieler spieler1 = new Spieler();
            Spieler spieler2 = new Spieler();

            bool aktuellerSpieler1 = true;
            bool gameover = false;
            int aktuellerAngriff = 0;

            // Hier beginnt der Game Loop / Spiel Schleife läuft solange nicht gameover ist
            do
            {
                Console.WriteLine("Bitte wählen Sie:");
                Console.WriteLine("[1] Normaler Angriff");
                Console.WriteLine("[2] Spezial Angriff");
                int eingabe = Convert.ToInt32(Console.ReadLine());

                // Den User Input verarbeiten
                switch (eingabe)
                {
                    case 1:
                        //Code für Normaler Angriff
                        if (aktuellerSpieler1)
                            Console.WriteLine("Spieler 1 hat " + aktuellerAngriff + "Schaden gemacht 1");
                        spieler2.lebenspunkte -= aktuellerAngriff;
                }

                else
                {
                    aktuellerAngriff = spieler2.NormalerAngriff();
                    Console.WriteLine("Spieler 2 hat " + aktuellerAngriff + "Schaden gemacht 1");
                    spieler1.lebenspunkte -= aktuellerAngriff;
                }

                break;
            }

            case 2:
            // Code für spezial Angriff
            if (aktuellerSpieler1)
            {
                aktuellerAngriff = spieler2.SpezialAngriff();
                Console.WriteLine("Spieler 1 hat " + aktuellerAngriff + "Schaden gemacht 1");
                spieler2.lebenspunkte -= aktuellerAngriff;
            }
        }
        else

        {
                aktuellerAngriff = spieler2.SpezialAngriff();
                Console.WriteLine("Spieler 2 hat "  + aktuellerAngriff + "Schaden gemacht 1");
                spieler1.lebenspunkte -= aktuellerAngriff;
            }
                
            break;
                
               //Check wer gewonnen hat
               if (spieler1.lebenspunkte <= 0)
               {
                   Console.WriteLine("Spieler 2 hat gewonnen !!");
                   gameover = true;
               }
               else if (spieler2.lebenspunkte <= 0)
               {
                   Console.WriteLine("Spieler 1 hat gewonnen !!");
                   gameover = true;
               }
               Console.WriteLine("Spieler 1 Lebenspunkte:" + spieler1.lebenspunkte);
               Console.WriteLine("Spieler 2 Lebenspunkte:" + spieler2.lebenspunkte);

                aktuellerSpieler1 = !aktuellerSpieler1;
            } while (gameover != true);
        }
    }

public class Spieler
    {
        
    }
}