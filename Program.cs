namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe1: Lottozahlen
            //Erstelle ein int[] lottozahlen mit der Länge 49.
            //Schreibe dann einen Code, der dieses Array automatisch mit den Zahlen 1 - 49 befüllt.

            //Aufgabe2: Ziehung der Lottozahlen
            //Aus dem Array unserer Lottozahlen sollen nun sechs Zahlen zufällig gezogen werden.
            //Diese sechs Zahlen müssen in einem neuen Array abgelegt werden.
            //Verwende Random für die zufällige Ziehung.
            //Bei gezogene Zahlen darf es zu keiner Dopplung kommen.

            //Aufgabe 3: User-Eingabe und Gewinnausgabe
            //Der User soll in der Lage sein, sechs Zahlen einzugeben.
            //Diese werden in einem Array abgelegt. 
            //Danach soll überprüft werden, wieviele Zahlen der User im Vergleich zu den gezogenen Lottozahlen richtig getippt hat. Sprich, wieviele Zahlen in den beiden Arrays sind gleich. 
            //Gib in der Konsole aus, wieviele Richtige getippt wurden.

            Console.WriteLine("WANNA WIN THE MILLION DOLLAR PRIZE?! LETS GIVE IT A SHOT.\nEnter the first number. (from 1 to 49)");
            int spielerZahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now the second one:");
            int spielerZahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now the third one:");
            int spielerZahl3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now the fourth one:");
            int spielerZahl4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now the fifth one:");
            int spielerZahl5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And the last one:");
            int spielerZahl6 = Convert.ToInt32(Console.ReadLine());

            int[] spielerZahlen = { spielerZahl1, spielerZahl2, spielerZahl3, spielerZahl4, spielerZahl5, spielerZahl6, };
            int[] lottoZahlen = new int[49];

            for (int i = 0; i < 49; i++)
            {
                lottoZahlen[i] = i + 1;
            }

            int[] sechsZahlen = new int[6];
            Random rng = new Random();

            for (int i = 0; i < 6; i++)
            {
                int o = rng.Next(0, 49 - i);
                sechsZahlen[i] = lottoZahlen[o];
                lottoZahlen[o] = lottoZahlen[48 - i];
            }

            foreach (int richtigeLottoZahl in sechsZahlen)
                Console.WriteLine($"PLAY2WIN {richtigeLottoZahl}");

            int ergebnis1 = 0;
            int ergebnis2 = 0;
            int ergebnis3 = 0;
            int ergebnis4 = 0;
            int ergebnis5 = 0;
            int ergebnis6 = 0;


            if (spielerZahlen[0] == sechsZahlen[0] || spielerZahlen[0] == sechsZahlen[1] || spielerZahlen[0] == sechsZahlen[2] || spielerZahlen[0] == sechsZahlen[3] || spielerZahlen[0] == sechsZahlen[4] || spielerZahlen[0] == sechsZahlen[5])
            {
                ergebnis1 = 1;
            }
            if (spielerZahlen[1] == sechsZahlen[0] || spielerZahlen[1] == sechsZahlen[1] || spielerZahlen[1] == sechsZahlen[2] || spielerZahlen[1] == sechsZahlen[3] || spielerZahlen[1] == sechsZahlen[4] || spielerZahlen[1] == sechsZahlen[5])
            {
                ergebnis2 = 1;
            }
            if (spielerZahlen[2] == sechsZahlen[0] || spielerZahlen[2] == sechsZahlen[1] || spielerZahlen[2] == sechsZahlen[2] || spielerZahlen[2] == sechsZahlen[3] || spielerZahlen[2] == sechsZahlen[4] || spielerZahlen[2] == sechsZahlen[5])
            {
                ergebnis3 = 1;
            }
            if (spielerZahlen[3] == sechsZahlen[0] || spielerZahlen[3] == sechsZahlen[1] || spielerZahlen[3] == sechsZahlen[2] || spielerZahlen[3] == sechsZahlen[3] || spielerZahlen[3] == sechsZahlen[4] || spielerZahlen[3] == sechsZahlen[5])
            {
                ergebnis4 = 1;
            }
            if (spielerZahlen[4] == sechsZahlen[0] || spielerZahlen[4] == sechsZahlen[1] || spielerZahlen[4] == sechsZahlen[2] || spielerZahlen[4] == sechsZahlen[3] || spielerZahlen[4] == sechsZahlen[4] || spielerZahlen[4] == sechsZahlen[5])
            {
                ergebnis5 = 1;
            }
            if (spielerZahlen[5] == sechsZahlen[0] || spielerZahlen[5] == sechsZahlen[1] || spielerZahlen[5] == sechsZahlen[2] || spielerZahlen[5] == sechsZahlen[3] || spielerZahlen[5] == sechsZahlen[4] || spielerZahlen[5] == sechsZahlen[5])
            {
                ergebnis6 = 1;
            }

            int ergebnisFinal = ergebnis1 + ergebnis2 + ergebnis3 + ergebnis4 + ergebnis5 + ergebnis6;

            Console.WriteLine($"YOU HAVE MANAGED TO GIVE {ergebnisFinal} NUMBERS CORRECT. GRATS! XD");

            Console.ReadKey(); 
        }
    }
}