using System;

namespace Calculadora
{
    class Program
    {
        //Paolo Antonio Grometto Ramirez ID:1104093
        static void Main(string[] args)
        {
            int SueldoBruto;
            Console.WriteLine("[+]Digite el sueldo bruto: ");
            SueldoBruto = Convert.ToInt32(Console.ReadLine());

            double AFP;
            double ISR;
            double SSF;
            double total;
            double neto;

            AFP = SueldoBruto * 0.09;
            ISR = SueldoBruto * 0.07;
            SSF = SueldoBruto * 0.10;
            total = ISR + AFP + SSF;
            neto = SueldoBruto - total;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("[-]El sueldo bruto es: " + SueldoBruto); 
            Console.WriteLine("[-]El descuento AFP es: " + AFP);        
            Console.WriteLine("[-]El descuento descuento ISR es: " + ISR); 
            Console.WriteLine("[-]El descuento SSF es: " + SSF);        
            Console.WriteLine("[-]El sueldo neto es igual a: " + neto);
            Console.WriteLine("---------------------------------------------------------------");


        }
    }
}
