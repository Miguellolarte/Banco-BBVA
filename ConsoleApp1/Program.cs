using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                datospedir();
            }
            public static void datospedir()
            {
                var prestamoMes = 17000000 / 12;
                var interesPres = 0.02;
                var i = 0;
                double interes = 0;
                double result = 0;
                double contador = 0;

                var fecha = new DateTime(2018, 01, 01);

                Console.WriteLine("Su prestamo fue de 17.000.000 Millones y su valor a cancelar por mes sin intereses es de:{0}", prestamoMes);
                Console.WriteLine("La fecha de peticion de este dinero fue el :{0}", fecha);

                for (i = 1; i <= 12; i++)
                {


                    while (i < 13)
                    {
                        DateTime fechaCompacta = new DateTime(2019, 04, 01);
                        Console.WriteLine("fecha compacta es: {0}", fechaCompacta.ToString("yyyy/MM/dd"));
                        var fechaCompactaTwo = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("tun fecha{0}", fechaCompactaTwo.ToString("yyyy/MM/dd"));
                        interes = prestamoMes * interesPres;
                        result = prestamoMes + interes;
                        Console.WriteLine("Su mes a pagar por mes es de :{0}", i);
                        Console.WriteLine("intereses del 2% es: {0} y su valor apagar es: {1} y su fecha es:{2} ", interes, result, fechaCompacta);
                    }
                    contador = contador + result;
                    Console.WriteLine("{0}", contador);

                }

                Console.ReadLine();
            }
        }
    }
}
