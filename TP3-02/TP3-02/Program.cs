using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double OpCa = 1000.00, OpMa = 850.00, OpCo = 700.00, Opcion, Dia, Opcion2, Horas, Resultado;
            int prohibido = 131313;
            while (true)
            {
                Console.Clear();


                /*ENUNCIADO*/
                Console.WriteLine(" En una Fábrica trabajan tres categorías de operarios: Operario Calificado (A), Operario\n Maquinista(B) y Operario Común(C).Por cada hora trabajada, y en base a la categoría los operarios cobran: " +
    "\n * Operario Calificado $ 1000, 00 x hora." +
    "\n * Operario Maquinista $ 850, 00 x hora." +
    "\n * Operario Común $ 700, 00 x hora.\n\n");




                /*MENU PRINCIPAL*/
                Console.WriteLine(" Programa para saber cuanto gana un Operario segun su categoria\n");
               
                
                Console.WriteLine(" >>>>>>>> MENU <<<<<<<<<\n");             
                Console.WriteLine($" 1-> Operario Calificado (${OpCa} por hora)");
                Console.WriteLine($" 2-> Operario Maquinista (${OpMa} por hora)");
                Console.WriteLine($" 3-> Operario Común (${OpCo} por hora)");
                Console.WriteLine(" 4-> AJUSTES");
                Console.WriteLine(" 5-> SALIR\n");
                Console.Write(" Que tipo de Operario eres: ");

                Opcion = int.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case 1:
                        {

                            /*MENU OPERARIO CALIFICADO */
                            Console.Clear();
                            Console.WriteLine(" Por defecto un operario trabaja 8 horas diarias\n");
                            Console.WriteLine(" 1-> Total por dia(8horas)");
                            Console.WriteLine(" 2-> Total por semana (5 dias)");
                            Console.WriteLine(" 3-> Total por quincena(10 dias)");
                            Console.WriteLine(" 4-> Total por mes (20 dias laborales)");
                            Console.WriteLine(" 5-> Ingresar las horas que trabajaste (Podes ingresar la cantidad de horas que desees)");
                            Console.WriteLine(" 6-> VOLVER\n");
                            Console.Write(" Ingrese una opción: ");
                            Opcion2 = int.Parse(Console.ReadLine());
                            switch (Opcion2)
                            {
                                case 1:
                                    {
                                        Dia = 8 * OpCa;
                                        Console.WriteLine($"\n Ganas un total de ${Dia} por dia laburando 8 horas diariamente");
                                        Console.Write("\n\n Enter para volver al Menu Pincipal.....");
                                        break;
                                    }
                                case 2:
                                    {
                                        Dia = (8 * 5) * OpCa;
                                        Console.WriteLine($"\n Ganas un total de ${Dia} por dia laburando 8 horas diarias durante una semana");
                                        Console.Write("\n\n Enter para volver al Menu Pincipal.....");
                                        break;
                                    }
                                case 3:
                                    {
                                        Dia = (8 * 10) * OpCa;
                                        Console.WriteLine($"\n Ganas un total de ${Dia} por dia laburando 8 horas diarias durante una semana");
                                        Console.Write("\n\n Enter para volver al Menu Pincipal.....");
                                        break;
                                    }
                                case 4:
                                    {
                                        Dia = (8 * 20) * OpCa;
                                        Console.WriteLine($"\n Ganas un total de ${Dia} por dia laburando 8 horas diarias durante una quincena");
                                        Console.Write("\n\n Enter para volver al Menu Pincipal.....");
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.Clear();
                                        Console.Write(" Ingrese la cantidad de horas que laburaste durante un determinado tiempo: ");
                                        Horas = int.Parse(Console.ReadLine());
                                        Resultado = OpCa * Horas;
                                        Console.WriteLine($"\n Ganaste un total de ${Resultado} durante {Horas} horas");
                                        Console.Write("\n\n Enter para volver al Menu Pincipal.....");
                                        break;
                                    }
                                case 6:
                                    {
                                        Console.Clear();
                                        Console.Write(" Enter para continuar....");
                                        break;
                                    }
                            }

                            break;
                        }


                    case 2:
                        
                        {
                            /*MENU OPERARIO MAQUINISTA */
                            Console.Clear();
                            Console.WriteLine(" Por defecto un operario trabaja 8 horas diarias\n");
                            Console.WriteLine(" 1-> Total por dia(8horas)");
                            Console.WriteLine(" 2-> Total por semana (5 dias)");
                            Console.WriteLine(" 3-> Total por quincena(10 dias)");
                            Console.WriteLine(" 4-> Total por mes (20 dias laborales)");
                            Console.WriteLine(" 5-> Ingresar las horas que trabajaste (Podes ingresar la cantidad de horas que desees)");
                            Console.WriteLine(" 6-> VOLVER\n");
                            Console.Write(" Ingrese una opción: ");
                            Opcion2 = int.Parse(Console.ReadLine());
                            switch (Opcion2)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Dia = 8 * OpMa;
                                        Console.WriteLine($" Ganas un total de ${Dia} por dia laburando 8 horas diariamente");
                                        Console.Write("\n\n Enter para volver al Menu Pincipal.....");
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Clear();
                                        Dia = (8 * 5) * OpMa;
                                        Console.WriteLine($" Ganas un total de ${Dia} por dia semana laburando 8 horas diarias durante una semana");
                                        Console.Write("\n\n Enter para volver al Menu Pincipal.....");
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Clear();
                                        Dia = (8 * 10) * OpMa;
                                        Console.WriteLine($" Ganas un total de ${Dia} por dia quincena laburando 8 horas diarias durante una semana");
                                        Console.Write("\n\n Enter para volver al Menu Pincipal.....");
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Clear();
                                        Dia = (8 * 20) * OpMa;
                                        Console.WriteLine($" Ganas un total de ${Dia} por mes laburando 8 horas diarias durante una quincena");
                                        Console.Write("\n\n Enter para volver al Menu Pincipal.....");
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.Clear();
                                        Console.Write(" Ingrese la cantidad de horas que laburaste durante un determinado tiempo: ");
                                        Horas = int.Parse(Console.ReadLine());
                                        Resultado = OpMa * Horas;
                                        Console.WriteLine($" Ganaste un total de ${Resultado} durante {Horas} horas");
                                        Console.Write("\n\n Enter para volver al Menu Pincipal.....");
                                        break;
                                    }
                                case 6:
                                    {
                                        Console.Clear();
                                        Console.Write(" Enter para continuar....");
                                        break;
                                    }
                            }

                            break;
                        }
                    case 3:
                        {
                            /*MENU OPERARIO COMUN */
                            Console.Clear();
                            Console.WriteLine(" Por defecto un operario trabaja 8 horas diarias\n");
                            Console.WriteLine(" 1-> Total por dia(8horas)");
                            Console.WriteLine(" 2-> Total por semana (5 dias)");
                            Console.WriteLine(" 3-> Total por quincena(10 dias)");
                            Console.WriteLine(" 4-> Total por mes (20 dias laborales)");
                            Console.WriteLine(" 5-> Ingresar las horas que trabajaste (Podes ingresar la cantidad de horas que desees)");
                            Console.WriteLine(" 6-> VOLVER\n");
                            Console.Write(" Ingrese una opción: ");
                            Opcion2 = int.Parse(Console.ReadLine());
                            switch (Opcion2)
                            {
                                case 1:
                                    {
                                      
                                        Dia = 8 * OpCo;
                                        Console.WriteLine($"Ganas un total de ${Dia} por dia laburando 8 horas diariamente");
                                        Console.Write("\n\nEnter para volver al Menu Pincipal.....");
                                        
                                        break;
                                    }
                                case 2:
                                    {
                                        Dia = (8 * 5) * OpCo;
                                        Console.WriteLine($"Ganas un total de ${Dia} por semana laburando 8 horas diarias durante una semana");
                                        Console.Write("\n\n Enter para volver al Menu Pincipal.....");
                                        break;
                                    }
                                case 3:
                                    {
                                        Dia = (8 * 10) * OpCo;
                                        Console.WriteLine($"Ganas un total de ${Dia} por dia quincena laburando 8 horas diarias durante una semana");
                                        Console.Write("\n\n Enter para volver al Menu Pincipal.....");
                                        break;
                                    }
                                case 4:
                                    {
                                        Dia = (8 * 20) * OpCo;
                                        Console.WriteLine($"Ganas un total de ${Dia} por mes laburando 8 horas diarias durante una quincena");
                                        Console.Write("\n\n Enter para volver al Menu Pincipal.....");
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.Write("Ingrese la cantidad de horas que laburaste durante un determinado tiempo: ");
                                        Horas = int.Parse(Console.ReadLine());
                                        Resultado = OpCo * Horas;
                                        Console.WriteLine($"Ganaste un total de ${Resultado} durante {Horas} horas");
                                        Console.Write("\n\n Enter para volver al Menu Pincipal.....");
                                        break;
                                    }
                                case 6:
                                    {
                                        Console.Clear();
                                        Console.Write(" Enter para continuar....");
                                        break;
                                    }
                            }

                            break;
                        }
                    case 4:
                        {
                            /*MENU DE AJUSTES*/
                            
                            Console.Clear();
                            

                            /******** Verificador de Contraseña****/
                            int correcto = prohibido, contrasenia;
                            do
                            {
                                Console.Write(" Ingrese Contraseña: ");
                                contrasenia = int.Parse(Console.ReadLine());
                                if (contrasenia != correcto)
                                {
                                    Console.WriteLine(" Contraseña Incorrecta");
                                }
                            }while (contrasenia != correcto);
                            Console.WriteLine(" Contraseña Correcta...\n Presione Enter para continuar...");
                            Console.ReadKey();
                            Console.Clear();

                            /*********FIN******/


                     
                            Console.WriteLine(" [1] Cambiar monto que gana cada operario por hora");                            
                            Console.WriteLine(" [2] Cambiar Contraseña del ADMINISTRADOR\n");
                            Console.Write(" Ingrese la opcion de cual operario quieres camiar el monto por hora: ");
                            Opcion = int.Parse(Console.ReadLine());
                            switch (Opcion)
                            {

                                /*MENU DE AJUSTES PARTE 2*/
                                case 1:
                                    {
                                        /*MENU DE CAMBIO DE MONTO */
                                        Console.WriteLine(" [1] Operario Calificado");
                                        Console.WriteLine(" [2] Operario Maquinista");
                                        Console.WriteLine(" [3] Operario Común\n");
                                        Opcion2 = int.Parse(Console.ReadLine());
                                        switch (Opcion2)
                                        {
                                            case 1:
                                                {
                                                    Console.Clear();
                                                    Console.Write(" Ingrese el monto que deseas agregar: ");
                                                    OpCa = int.Parse(Console.ReadLine());
                                                    Console.Clear();
                                                    Console.WriteLine($" El monto por hora que gana un Oprario Calificado ahora es de ${OpCa}\n\n Volviendo al MENU principal (Enter Para Continuar)....");

                                                    break;
                                                }
                                            case 2:
                                                {
                                                    Console.Clear();
                                                    Console.Write(" Ingrese el monto que deseas agregar: ");
                                                    OpMa = int.Parse(Console.ReadLine());
                                                    Console.Clear();
                                                    Console.WriteLine($" El monto por hora que gana un Oprario Maquinista ahora es de ${OpMa} \n\n Volviendo al MENU principal (Enter Para Continuar)....");

                                                    break;
                                                }
                                            case 3:
                                                {
                                                    Console.Clear();
                                                    Console.Write(" Ingrese el monto que deseas agregar: ");
                                                    OpCo = int.Parse(Console.ReadLine());
                                                    Console.Clear();
                                                    Console.WriteLine($" El monto por hora que gana un Oprario Común ahora es de ${OpCa} \n\n Volviendo al MENU principal (Enter Para Continuar)....");

                                                    break;
                                                }
                                            
                                   

                                                   
                                        }


                                        break;
                                    }
                                    
                                case 2:
                                    {

                                        /*CAMBIO DE CONTRASEÑA*/

                                        //Verificar CONTRASEÑA Actual
                                        do
                                        {
                                            Console.Clear();
                                            Console.Write(" Ingrese Contraseña actual: ");
                                            contrasenia = int.Parse(Console.ReadLine());
                                            if (contrasenia != correcto)
                                            {
                                                Console.WriteLine(" No es la Contraseña actual");
                                            }
                                        } while (contrasenia != correcto);
                                        Console.Clear();
                                        //Nueva CONTRASEÑA
                                        int prohibidoV, prohibidoV2;
                                        do
                                        {
                                            Console.Write(" Ingrese la nueva Contraseña: ");
                                            prohibidoV = int.Parse(Console.ReadLine());
                                            Console.Write(" Repita la nueva Contraseña: ");
                                            prohibidoV2 = int.Parse(Console.ReadLine());
                                            //Verificando semejanza de CONTRASEÑA
                                            if (prohibidoV2 != prohibidoV)
                                            {
                                                Console.WriteLine(" CONTRASEÑA no son iguales");
                                            }
                                        } while (prohibidoV2 != prohibidoV);

                                        prohibido = prohibidoV2;
                                        Console.Clear();
                                        Console.WriteLine($" La nueva Contraseña es {prohibido} \n\n Volviendo al MENU principal (Enter Para Continuar)....");

                                        break;
                                    }

                            } // FIN MENU DE AJUSTES PARTE 2
                            break;
                            

                            
                        }// FIN DE MENU DE AJUSTES



                        case 5:
                        {
                            /*CIERRE DE PROGRAMA */
                            Console.Clear();
                            Console.Write(" Cerrando Programa (Enter para continuar)....");
                            Console.ReadKey();
                            return;
                        }


                } // FIN 1° SWICH


                Console.ReadKey();
            }// FIN DO WHILE
        }// FIN MAIN

    } //FIN CLASSE PROGRAM
} // FIN NAMESPACE
