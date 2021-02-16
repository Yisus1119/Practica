String bank = "FDP INVERSMENTS";
               int retdeafult = 10000;
               int billetes_de_100 = 50, billetes_de_1000 = 18, billetes_de_200 = 23, billetes_de_500 = 19;
               int cantidad_de_pesos, efectivo;

               Console.WriteLine("Ingrese el nombre del banco:");
               string nm = Console.ReadLine();
               Console.WriteLine("El banco seleccionado es: " + nm);

               if (nm == bank)
               {
                   Console.WriteLine("El límite de retiro es 20,000");

                   int retiro = 20000;
                   Console.Write("Ingrese el valor de cantidad en Pesos Dominicanos: ");
                   cantidad_de_pesos = int.Parse(Console.ReadLine());
                   efectivo = cantidad_de_pesos;
                   if (cantidad_de_pesos <= retiro)
                   {
                    
                        billetes_de_1000 = (efectivo - efectivo % 1000) / 1000;
                        efectivo = efectivo % 1000;

                       billetes_de_500 = (efectivo - efectivo % 500) / 500;
                       efectivo = efectivo % 500;

                       billetes_de_200 = (efectivo - efectivo % 200) / 200;
                       efectivo = efectivo % 200;

                       billetes_de_100 = (efectivo - efectivo % 100) / 100;
                       efectivo = efectivo % 100;

                       Console.WriteLine("Valor de billetes de 1000: " + billetes_de_1000);
                       Console.WriteLine("Valor de billetes de 500: " + billetes_de_500);
                       Console.WriteLine("Valor de billetes de 200: " + billetes_de_200);
                       Console.WriteLine("Valor de billetes de 100: " + billetes_de_100);



                       Console.Write("Presione una tecla para terminar . . . ");
                       Console.ReadKey();
                   }
                   else
                   {
                       Console.WriteLine("El monto supera el límite de transacción.");
                   }


               } else if(nm != bank)
               {
                   Console.WriteLine("El monto máximo de transacción es de 10,000");
                   int retiro2 = 10000;
                   Console.Write("Ingrese el valor de cantidad de Pesos Dominicanos: ");
                   cantidad_de_pesos = int.Parse(Console.ReadLine());
                   efectivo = cantidad_de_pesos;
                   if (cantidad_de_pesos <= retiro2)
                   {
                       billetes_de_1000 = (efectivo - efectivo % 1000) / 1000;
                       efectivo = efectivo % 1000;

                       billetes_de_500 = (efectivo - efectivo % 500) / 500;
                       efectivo = efectivo % 500;

                       billetes_de_200 = (efectivo - efectivo % 200) / 200;
                       efectivo = efectivo % 200;

                       billetes_de_100 = (efectivo - efectivo % 100) / 100;
                       efectivo = efectivo % 100;

                       Console.WriteLine("Valor de billetes de 1000: " + billetes_de_1000);
                       Console.WriteLine("Valor de billetes de 500: " + billetes_de_500);
                       Console.WriteLine("Valor de billetes de 200: " + billetes_de_200);
                       Console.WriteLine("Valor de billetes de 100: " + billetes_de_100);



                       Console.Write("Presione una tecla para terminar . . . ");
                       Console.ReadKey();
                   }
                   else
                   {
                       Console.WriteLine("El monto supera el límite de transacción.");
                   }

               }