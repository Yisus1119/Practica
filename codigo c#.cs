using System;

namespace PracticaParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bancos = { { "FDP INVERSMENTS", "20000" }, { "Otro", "10000" } };
            int[] billetes = { "100", "200", "500", "1000" };

            Console.WriteLine("Bienvenido al cajero del bando FDP INVERSMENT");
            Console.WriteLine("1. FDP INVERSMENT\n" +
                "2. Otro\n" +
                "3. Cancelar\n");
            Console.WriteLine("Selecciona el banco de preferencia: \n");
            int seleccion = Convert.ToInt32(Console.ReadLine());

            while (true)
                if (seleccion == 1)
                {
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Has seleccionado el banco", bancos[0][0]);
                    Console.WriteLine("(el limite de transacción es ", bancos[0][1], ")");
                    Console.Write("Ingrese el valor de cantidad en Pesos Dominicanos: ");
                    int monto = Convert.ToInt32(Console.ReadLine());
                    if (monto <= bancos[0][1])
                    {
                        if (monto % billetes[3] == 0 && monto % billetes[0] == 0)
                        {
                            if (monto >= 19000 && monto < 20000)
                            {
                                billetes_de_1000 = (monto - monto % billetes[3]) / billetes[3];
                                billetes_de_1000 -= 1;
                                monto -= 18000;
                            }
                            else
                            {
                                if (monto == 20000)
                                {
                                    billetes_de_1000 = (monto - monto % billetes[3]) / billetes[3];
                                    billetes_de_1000 -= 2;
                                    monto -= 18000;
                                }
                                else
                                {
                                    billetes_de_1000 = (monto - monto % billetes[3] / billetes[3]);
                                    monto = monto % billetes[3];
                                }
                            }
                            billetes_de_500 = (monto - monto % billetes[2]) / billetes[2];
                            monto = monto % billetes[2];
                            billetes_de_200 = (monto - monto % billetes[1]) / billetes[1];
                            monto = monto % billetes[1];
                            billetes_de_100 = (monto - monto % billetes[0]) / billetes[0];
                            monto = monto % billetes[0];
                        }
                        else
                        {
                            aux = 0;
                            if (aux == 0)
                            {
                                Console.WriteLine("EL monto ingresado no puede ser dispensado, ingrese una centenas o millares");
                            }
                        }

                    }
                    else
                    {
                        aux = 0;
                        if (aux == 0)
                        {
                            Console.WriteLine("Has exedido el limite de transacción");
                        }
                    }
                }


                
                if (seleccion == 2)
                {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Has seleccionado el banco", bancos[0][0]);
                Console.WriteLine("(el limite de transacción es ", bancos[0][1], ")");
                Console.Write("Ingrese el valor de cantidad en Pesos Dominicanos: ");
                int monto = Convert.ToInt32(Console.ReadLine());
                if (monto <= bancos[1][1])
                {
                    if (monto % billetes[3] == 0 && monto % billetes[0] == 0)
                    {
                        billetes_de_1000 = (monto - monto % billetes[3] / billetes[3]);
                        monto = monto % billetes[3];
                        billetes_de_500 = (monto - monto % billetes[2]) / billetes[2];
                        monto = monto % billetes[2];
                        billetes_de_200 = (monto - monto % billetes[1]) / billetes[1];
                        monto = monto % billetes[1];
                        billetes_de_100 = (monto - monto % billetes[0]) / billetes[0];
                        monto = monto % billetes[0];
                    }
                    else
                    {
                        aux = 0;
                        if (aux == 0)
                        {
                            Console.WriteLine("EL monto ingresado no puede ser dispensado, ingrese una centenas o millares");
                        }
                    }

                }
                else
                {
                    aux = 0;
                    if (aux == 0)
                    {
                        Console.WriteLine("Has exedido el limite de transacción");
                        }
                }
            }

                Console.WriteLine("Valor de billetes de 1000: " + billetes_de_1000);
                Console.WriteLine("Valor de billetes de 500: " + billetes_de_500);
                Console.WriteLine("Valor de billetes de 200: " + billetes_de_200);
                Console.WriteLine("Valor de billetes de 100: " + billetes_de_100);





            }
        } 
}

            

         


        