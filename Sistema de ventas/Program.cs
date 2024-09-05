using System;

class Ferreteria
{
    static void Main(string[] args)
    {
        double total = 0;
        while (true)
        {
            Console.WriteLine("Bienvenidos al sistema de Ventas");
            Console.WriteLine("Seleccione la Categoria del Producto");
            Console.WriteLine("1. Herramientas");
            Console.WriteLine("2. Materiales de Construcción");
            Console.WriteLine("3. Electricidad");
            Console.WriteLine("salir");
            string categoria = Console.ReadLine();

            if (categoria == "4")
            {
                Console.WriteLine("El total a pagar es: " + total);
                break;
            }

            double subtotal = 0;
            double impuesto = 0;

            if (categoria == "1")
            {
                Console.WriteLine("Herramientas");
                Console.WriteLine("1. Taladro eléctrico 250lps");
                Console.WriteLine("2. Llave inglesa 120lps");
                Console.WriteLine("3. Martillo 80lps");
                string herramienta = Console.ReadLine();
                if (herramienta == "1")
                {
                    double precio = 250;
                    impuesto = precio * 0.10;
                    subtotal = precio + impuesto;
                }
                else if (herramienta == "2")
                {
                    double precio = 120;
                    impuesto = precio * 0.10;
                    subtotal = precio + impuesto;
                }
                else if (herramienta == "3")
                {
                    double precio = 80;
                    impuesto = precio * 0.10;
                    subtotal = precio + impuesto;
                }
                else
                {
                    Console.WriteLine("No tenemos el producto seleccionado");
                    continue;
                }
            }
            else if (categoria == "2")
            {
                Console.WriteLine("Materiales de Construcción");
                Console.WriteLine("1. Cemento 150lps");
                Console.WriteLine("2. Arena 100lps");
                Console.WriteLine("3. Grava 120lps");
                string material = Console.ReadLine();
                if (material == "1")
                {
                    double precio = 150;
                    impuesto = precio * 0.05;
                    subtotal = precio + impuesto;
                }
                else if (material == "2")
                {
                    double precio = 100;
                    impuesto = precio * 0.05;
                    subtotal = precio + impuesto;
                }
                else if (material == "3")
                {
                    double precio = 120;
                    impuesto = precio * 0.05;
                    subtotal = precio + impuesto;
                }
                else
                {
                    Console.WriteLine("No tenemos el producto seleccionado");
                    continue;
                }
            }
            else if (categoria == "3")
            {
                Console.WriteLine("Electricidad");
                Console.WriteLine("1. Cable eléctrico 200lps");
                Console.WriteLine("2. Interruptor 80lps");
                Console.WriteLine("3. Foco 100lps");
                string electricidad = Console.ReadLine();
                if (electricidad == "1")
                {
                    double precio = 200;
                    impuesto = precio * 0.15;
                    subtotal = precio + impuesto;
                }
                else if (electricidad == "2")
                {
                    double precio = 80;
                    impuesto = precio * 0.15;
                    subtotal = precio + impuesto;
                }
                else if (electricidad == "3")
                {
                    double precio = 100;
                    impuesto = precio * 0.15;
                    subtotal = precio + impuesto;
                }
                else
                {
                    Console.WriteLine("No tenemos el producto seleccionado");
                    continue;
                }
            }

            Console.WriteLine("El precio del producto es: " + (subtotal - impuesto));
            Console.WriteLine("El impuesto es: " + impuesto);
            Console.WriteLine("El subtotal es: " + subtotal);
            total += subtotal;

            Console.WriteLine("Quiere comprar algo mas? (si/no)");
            string respuesta = Console.ReadLine();
            if (respuesta.ToLower() == "no")
            {
                Console.WriteLine("El total a pagar es: " + total);
                break;
            }
        }
    }
}