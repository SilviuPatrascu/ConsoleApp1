using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] produse;
            StreamWriter reader = new StreamWriter("C:\\Users\\HP\\Desktop\\magazin.txt");

            int[] v = new int[4];
            int ok = 1;
            
            produse = new string[] { "1.Paine", "2.Lapte", "3.oua","4.branza","5.iaurt" };
            int[] pret= new int[] {2,5,10,20,4};

            for (int j=0; j<produse.Length; j++)
            { Console.WriteLine(produse[j] +" "+ pret[j]+ "lei");
               
            }int sum = 0;
            int cant = 1;
            while (ok == 1)
            {
                Console.WriteLine("cate produse doriti:");
                int i = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("scrieti nr corespunzator produsului");
                for (int j = 1; j <= i; j++)
                {

                    Console.WriteLine("produsul:");
                    v[j] = Convert.ToInt32(Console.ReadLine());
                    reader.WriteLine(produse[v[j]-1]);
                    Console.WriteLine("ce cantitate?");
                    cant= Convert.ToInt32(Console.ReadLine());
                    reader.WriteLine("x" + cant);
                    sum = sum + (pret[v[j] - 1]*cant);
                }

                reader.WriteLine("suma de plata:" + sum);
                
                Console.WriteLine("mai doriti ceva?,apasati 1 pentru da");
                int b= Convert.ToInt32(Console.ReadLine());
                if(b!=1)
                { ok = 0; }

            }reader.Close();
        }
    }
}