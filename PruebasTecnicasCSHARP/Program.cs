using System.Security.Cryptography.X509Certificates;

namespace PruebasTecnicasCSHARP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ejer01();
            //ejer02();
            //ejer03();
            //ejer04();
        }
        static public void ejer01()
        {
            //ejercicio 01: Dado un monto calcular el descuento considerando que por encima
            //de 100 el descuento es el 10% y por debajo de 100 el descuento es el 2%
            var monto = 500;
            var descuento = 0.00;
            var descuentoTotal = 00.00;
            if (monto > 100)
            {
                descuento = 0.10;
                descuentoTotal = monto * descuento;
            }
            else
            {
                descuento = 0.02;
                descuentoTotal = monto * descuento;
            }

            Console.WriteLine("El monto es: " + monto);
            Console.WriteLine("El descuento total es: " + descuentoTotal);
        }
        static public void ejer02()
        {
            //ejercicio 02: Se trata de escribir el algoritmo que permita emitir la factura
            //correspondiente a una compra de un articulo determinado, del que se adquieren
            //una o varias unidades. El IVA es del 19%, y si el precio bruto (precio venta + IVA)
            //es mayor de $13000 se debe realizar un descuento del 5%
            var producto = "laptop";
            var precio_producto = 3000; 
            var unidades_producto = 8;
            var IVA = 0.19;
            var precio_bruto = 0.00;
            var descuento = 0.00;
            var precio_total = 0.00;

            var precio_venta = precio_producto * unidades_producto;

            precio_bruto = precio_venta + (precio_venta*IVA);

            if (precio_bruto > 13000)
            {
                descuento = 0.05;
                precio_total = precio_bruto - (precio_bruto * descuento);
            }
            else
            {
                precio_total = precio_bruto;
            }

            Console.WriteLine("---------FACTURA---------");
            Console.WriteLine("El producto es: " + producto);
            Console.WriteLine($"El precio de {producto} es: " + precio_producto);
            Console.WriteLine("Unidades totales: " + unidades_producto);
            Console.WriteLine("El IVA es: 19%");
            Console.WriteLine("El precio bruto es: " + precio_bruto);
            Console.WriteLine("El descuento es: " + descuento*100 + "%");
            Console.WriteLine("El precio total es: " + precio_total);
        }
        static public void ejer03()
        {
            //ejercicio 03: Leer una serie de grupos de tres números y obtener el número mayor
            //y el número menor de cada terna. Escriba un mensaje si por lo menos dos de cada tres
            //números son iguales.ALGORITMO ternas mayor menor
            var num1 = 100;
            var num2 = 50;
            var num3 = 1;
            var num_mayor = 0;
            var num_menor = 0;

            if (num1>num2 && num1 > num3)
            {
                num_mayor = num1;

                if (num2 > num3)
                {
                    num_menor = num3;
                }
                else
                {
                    num_menor = num2;
                }
            }
            else if (num2 > num1 && num2 > num3)
            {
                num_mayor = num2;
                if (num1 > num3)
                {
                    num_menor = num3;
                }
                else
                {
                    num_menor = num1;
                }
            }
            else
            {
                num_mayor = num3;
                if (num1 > num2)
                {
                    num_menor = num2;
                }
                else
                {
                    num_menor = num1;
                }
            }
            Console.WriteLine("El numero mayor es: " + num_mayor);
            Console.WriteLine("El numero menor es: " + num_menor);
        }
        static public void ejer04()
        {
            //ejercicio 04: Un vendedor desea calcular su comisión total sobre la venta de
            //varios artículos. Al vendedor le corresponde el  5% de su comisión sobre artículos
            //cuyo precio es menor de $100 ,y el 7.5 %  de comisión sobre aquellos artículos cuyo
            //precio es de $100 o más. Suponga que el vendedor hizo  N  ventas
            var precio_producto = 300.00;
            var cantidad_producto = 2;
            var subtotal = 0.00;
            var comision = 0.00;
            var comision_total = 0.00;

            if (precio_producto >= 100)
            {
                comision = 0.075;
            }
            else
            {
                comision = 0.05;
            }

            subtotal = precio_producto * cantidad_producto;
            comision_total = subtotal * comision;
            Console.WriteLine("La comisión total del vendedor es: " + comision_total);
        }
    }
}