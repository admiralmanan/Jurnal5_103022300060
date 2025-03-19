// See https://aka.ms/new-console-template for more information
class PemrosesData
{
    public long DapatkanNilaiTerbesar<T>(T angka1, T angka2, T angka3)
    {
        dynamic Tbesar = 0;
        dynamic a1 = 0;
        dynamic a2 = 0;
        dynamic a3 = 0;
        a1 = angka1;
        a2 = angka2;
        a3 = angka3;
        Tbesar = a1;

        if (a1 > a2 && a1 > a3)
        {
            Tbesar = a1;
        }
        if (a2 > a1 && a2 > a3 ) {
            Tbesar = a2;  
        }
        if (a3 > a1 && a3 > a2){
            Tbesar = angka3;
        }
        return (Tbesar);

    }

    public static void Main()
    {
        long a = 10;
        long b = 30;
        long c = 22;
        PemrosesData pemrosesData = new PemrosesData();
        Console.WriteLine("Angka terbesar adalah " + pemrosesData.DapatkanNilaiTerbesar(a, b,c));    
    }
}