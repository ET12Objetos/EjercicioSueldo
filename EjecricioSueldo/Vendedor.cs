using System;
using System.Collections.Generic;
using System.Text;

namespace EjecricioSueldo
{
    public class Vendedor
    {
        public string Nombre { get; set; }

        public int Numero { get; set; }

        public double SueldoBasico { get; }
        
        public double SueldoExtra { get; }
        
        public double Bono { get; }

        public int CantVentas { get; set; }

        public Vendedor(string nombre, int numero, double sueldoBasico, double sueldoExtra, double bono, int cantVentas)
        {
            Nombre = !string.IsNullOrEmpty(nombre) ? nombre : throw new Exception("El nombre no puede ser cadena vacia");
           
            Numero = numero;
            
            if (sueldoBasico > 0)
                SueldoBasico = sueldoBasico;
            else
                throw new Exception("El sueldo basico es incorrecto");
            
            SueldoExtra = sueldoExtra > 0 ? sueldoExtra : throw new Exception("El sueldo extra es incorrecto");

            Bono = bono > 0 ? bono : throw new Exception("El bono es incorrecto");

            CantVentas = cantVentas >= 0 ? cantVentas : throw new Exception("Cantidad de ventas incorrecta");
        }

        public void InformarSueldo()
        {
            Console.WriteLine($"El sueldo de {Nombre} es: {CalcularSueldo()}");
        }

        private double CalcularSueldo() => SueldoBasico + SueldoExtra + Bono * CantVentas;
        
        //private double CalcularSueldo()
        //{
        //    return SueldoBasico + SueldoExtra + Bono * CantVentas;
        //}
    }
}
