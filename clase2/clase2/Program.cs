using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase2.clases;
namespace clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Nota nota = new Nota();
            try
            {
                nota.Nombre = "Lauren Michelle Jauregui";
                nota.Actividad1p = 7;
                nota.Practica1p = 5;
                nota.Tarea1p = 2;
                nota.EvaluacionFinald1p = 4;

                nota.Actividad2p = 10;
                nota.Practica2p = 10;
                nota.Tarea2p = 10;
                nota.EvaluacionFinald2p = 5;

                nota.Recuperacion = 10;


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Nombre :"                +nota.Nombre);

            Console.WriteLine(      "*****PRIMER PARCIAL*****"     );

            Console.WriteLine("ACT 1P :"           +nota.Actividad1p);
            Console.WriteLine("PRAC 1P :"          + nota.Practica1p);
            Console.WriteLine("TAREA 1P :"            + nota.Tarea1p);
            Console.WriteLine("EF 1P :" +    nota.EvaluacionFinald1p);
            Console.WriteLine("PRIMER PARCIAL :"   + nota.Practica1p);

            Console.WriteLine(      "*****SEGUNDO PARCIAL*****"     );

            Console.WriteLine("ACT 2P :"          + nota.Actividad2p);
            Console.WriteLine("PARC 2P :"          + nota.Practica2p);
            Console.WriteLine("TAREA 2P :"            + nota.Tarea2p);
            Console.WriteLine("EF 1P :"    + nota.EvaluacionFinald1p);
            Console.WriteLine("SEGUNDO PARCIAL:"+nota.SegundoParcial);

            Console.WriteLine("SUMA :"                   + nota.Suma);
            Console.WriteLine("RECUPERACION :"   + nota.Recuperacion);
            Console.WriteLine("FINAL :"                 + nota.Final);

            Console.WriteLine( "Estado : "             + nota.Estado);

            Console.WriteLine(      "*****FELICIDADES*****"         );
            Console.ReadKey();




        }
    }
}
