using System;

namespace EjecricioSueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese numero: ");
            int numeroVendedor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese Sueldo Basico: ");
            double sueldoBasico = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese Sueldo Extra: ");
            double sueldoExtra = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese Bono: ");
            var bono = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese cantidad ventas: ");
            int cantVentas = Convert.ToInt32(Console.ReadLine());

            Vendedor vendedora;

            vendedora = new Vendedor(nombre, numeroVendedor, sueldoBasico, sueldoExtra, bono, cantVentas);

            vendedora.InformarSueldo();
        }
    }
}
