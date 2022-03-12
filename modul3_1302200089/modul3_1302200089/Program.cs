
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302200089
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //soal buah
            KodeBuah fruit = new KodeBuah();

            String buahBaru = fruit.getKodeBuah(KodeBuah.buah.Apel);
            Console.WriteLine("Apel -> "+buahBaru);

            Console.WriteLine("\n");

            //soal game
            PosisiKarakterGame game = new PosisiKarakterGame();
            Console.WriteLine("State sekarang = " + game.currentState);
            Console.WriteLine("\n");

            game.activeTrigger(PosisiKarakterGame.Trigger.TombolW);
            Console.WriteLine("State sekarang = " + game.currentState);
            Console.WriteLine("\n");

            game.activeTrigger(PosisiKarakterGame.Trigger.TombolX);
            Console.WriteLine("State sekarang = " + game.currentState);
            Console.WriteLine("\n");

            game.activeTrigger(PosisiKarakterGame.Trigger.TombolS);
            Console.WriteLine("State sekarang = " + game.currentState);
            Console.WriteLine("\n");

            game.activeTrigger(PosisiKarakterGame.Trigger.TombolW);
            Console.WriteLine("State sekarang = " + game.currentState);
            Console.WriteLine("\n");

            game.activeTrigger(PosisiKarakterGame.Trigger.TombolW);
            Console.WriteLine("State sekarang = " + game.currentState);
            Console.WriteLine("\n");

            Console.WriteLine("Selesai!");
        }
    }

}
