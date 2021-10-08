using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3.__clase1
{
    class Patito
    {
        double n1, n2, resultado; //variable global
        public void Menu()
        {
            
            int opc;
            Console.WriteLine("selecciona una opción");
            Console.WriteLine("1.- sumar");
            Console.WriteLine("2.- restar");
            Console.WriteLine("3.- multiplicar");
            Console.WriteLine("4.- dividir");
            opc = int.Parse(Console.ReadLine());
            if (opc < 1 || opc > 4)
            {
                Console.WriteLine("opcion incorrecta");
                Menu();//recursivilidad: regresa al menu
            }
            else
            {
                Introducir();
                switch (opc)
                {
                    case 1:
                        Sumar();
                        break;

                    case 2:
                        Restar();
                        break;

                    case 3:
                        Multiplicar();
                        break;

                    case 4:
                        Dividir();
                        break;

                }
                Imprimir();
            }
        }
        public void Sumar()
        {
            resultado = n1 + n2;
        }
        public void Restar()
        {
            resultado = n1 - n2;
        }
        public void Multiplicar()
        {
            resultado = n1 * n2;
        }
        public void Dividir()
        {
            resultado = n1 / n2;
        }
        public void Introducir()
        {
            Console.WriteLine("introduce 2 numeros");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
        }
        public void Imprimir()
        {
            Console.WriteLine("el resultado de la operacion es: " + resultado);
        }
    }
}
