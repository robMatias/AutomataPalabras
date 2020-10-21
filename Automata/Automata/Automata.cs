using System;
using System.Drawing;

namespace Automata
{

    //MATIAS OLARTE SERVADO
    class Automata
    {
        int Cont;
        char [] Car;
        string PaEvaluar;
        static void Main(string[] args)
        
        {
            Automata aut = new Automata();
            Console.WriteLine("Matias Olarte Servado \n");
            Console.WriteLine("Escribe la palabra a evaluar");
            aut.PaEvaluar = Console.ReadLine();

            aut.Car = aut.PaEvaluar.ToCharArray(0, aut.PaEvaluar.Length);
            aut.Inicio();
            Console.WriteLine("\n presione cuaquilquier tecla para salir del programa...");
            Console.ReadKey();
        }

        public void Inicio()
        {
            Cont = 0;
            q0();
        }
        public void palabraRechazada()
        {
            Console.WriteLine("No puedo aceptar esta palabra en el lenguaje");
        }
        public void q0()
        {
            
            if (Cont < Car.Length)
            {
                switch (Car[Cont])
                {
                    case 'a':
                        Cont++;
                        q1();
                        break;
                    case 'c':
                        Cont++;
                        q2();
                        break;

                    default:
                        palabraRechazada();
                        break;

                }
            }
        }
        public void q1()
        {
            switch (Car[Cont])
            {
                case 'b':
                    Cont++;
                    if (Car[Cont] == 'c')
                    {
                        Cont++;
                        q3();
                    }
                    break;
                default:
                    palabraRechazada();
                    break;
            }
        }
        public void q2()
        {
            switch (Car[Cont])
            {
                case 'd':
                    Cont++;
                    if (Car[Cont] == 'a')
                    {
                        Cont++;
                        q3();
                    }
                    break;
                default:
                    palabraRechazada();
                    break;
            }
        }
        public void q3()
        {
            switch (Car[Cont])
            {
                case 'a':
                    Cont++;
                    q4();
                    break;
                case 'b':
                    Cont++;
                    q3();
                    break;
                case 'c':
                    Cont++;
                    q4();
                    break;
                case 'd':
                    Cont++;
                    q3();
                    break;
                default:
                    palabraRechazada();
                    break;
            }
        }
        public void q4()
        {
            switch (Car[Cont])
            {
                case 'a':
                    Cont++;
                    if (Car[Cont] == 'a')
                    {
                        q5();
                    }
                    else
                    {
                        q3();
                    }
                    break;
                case 'c':
                    Cont++;
                    if (Car[Cont] == 'c')
                    {
                        q5();
                    }
                    else
                    {
                        q3();
                    }
                    break;

                default:
                    palabraRechazada();
                    break;
            }

        }
        public void q5()
        {

            switch (Car[Cont])
            {
                case 'a':
                    Cont++;
                    q5();
                    break;
                case 'b':
                    Cont++;
                    q6();
                    break;
                case 'c':
                    Cont++;
                    q5();
                    break;
                case 'd':
                    Cont++;
                    q5();
                    break;

                default:
                    palabraRechazada();
                    break;
            }
        }
        public void q6()
        {
            switch (Car[Cont])
            {
                case 'b':
                    Cont++;
                    q7();
                    break;
                default:
                    q5();
                    break;
            }

        }
        public void q7()
        {

            if (Car[Cont] == 'a')
            {
                Console.WriteLine("La palabra " + PaEvaluar + " fue aceptada correctamente");
            }
            else
            {
                palabraRechazada();
            }
        }
    }
}
