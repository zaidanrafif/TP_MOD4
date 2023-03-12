public class KodePos
{
    public enum Kelurahan { Batununggal, Kujangsari, Mengger, Weters, Cijaura, Jatisari, Margasari, Sekajati, Kebonwaru, Maleer, Samoja }
    public static int getKodePos(Kelurahan kel)
    {
        int[] kodepos = { 40266, 40287, 40256, 40287, 40286, 40272, 40274, 40273 };
        return kodepos[(int)kel];
    }
}

public class doorMachine
{
    enum state { terkunci, terbuka};

    public static void Main()
    {
        int getKodePos = KodePos.getKodePos(KodePos.Kelurahan.Kujangsari);
        Console.WriteLine(getKodePos);
        Console.WriteLine();

        state state1 = state.terkunci;
        string[] kondisi = { "Pintu terkunci", "Pintu terbuka" };
        while (state1 != null)
        {
            Console.WriteLine(kondisi[(int)state1]);
            Console.WriteLine();
            Console.WriteLine("Masukkan perintah: ");

            string perintah = Console.ReadLine();
            switch (state1)
            {
                case state.terkunci:
                    if(perintah == "Kunci pintu")
                    {
                        state1 = state.terkunci;
                    }
                    else if (perintah == "Buka pintu")
                    {
                        state1 = state.terbuka;
                    }
                    else
                    {
                        state1 = state.terkunci;
                        Console.WriteLine("Perintah salah");
                    }
                    Console.WriteLine();
                    break;

                case state.terbuka:
                    if(perintah == "Kunci pintu")
                    {
                        state1 = state.terkunci;
                    }
                    else if (perintah == "buka pintu")
                    {
                        state1 = state.terbuka;
                    }
                    else
                    {
                        state1 = state.terbuka;
                        Console.WriteLine("Perintah salah");
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
            }
        }
    }
}