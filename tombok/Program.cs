namespace tombok
{
    internal class Program
    {
        static string[] torpok = new string[7];
        static void TorpokLetrehozasa()
        {
            torpok[0] = "Szundi";
            torpok[1] = "Szende";
            torpok[2] = "Hapci";
            torpok[3] = "Morgo";
            torpok[4] = "Tudor";
            torpok[5] = "Vidor";
            torpok[6] = "Kuka";
        }

        static void TorpokKiirasa()
        {
            Console.WriteLine($"A torpok lista elemeinek szama: {torpok.Length}");
            for (int i = 0; i < torpok.Length; i++)
            {
                Console.WriteLine(torpok[i]);
            }
        }

        static void Csere()
        {
            Console.Write("Melyik torpot csereljuk le?");
            string nev = Console.ReadLine();

            //kivalasztas tetele: van-e a tombben ilyen nev es ha van hanyadik helyen
            int index = 0;
            while (index < torpok.Length && torpok[index] != nev)
            {
                index++;
            }
            if (index < torpok.Length) 
            {
            
                Console.Write("Melyik torpre csereljuk le?");
                string ujNev = Console.ReadLine();
                torpok[index] = ujNev;
                Console.WriteLine("Lecserelve!");
            }
            else
            {
                Console.WriteLine("Nincs ilyen torp a listaban!");
            }
        }

        static void Main(string[] args)
        {
            TorpokLetrehozasa();
            TorpokKiirasa();
            Csere();
            TorpokKiirasa();
        }
    }
}
