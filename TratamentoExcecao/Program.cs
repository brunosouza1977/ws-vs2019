using System;
using TratamentoExcecao.Entities;
using TratamentoExcecao.Entities.Exceptions;

namespace TratamentoExcecao
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.WriteLine("Room number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Check in date: (dd/mm/yyyy ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check out date: (dd/mm/yyyy ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            
            Reservation reservation = new Reservation(number, checkin, checkout);
            Console.WriteLine("Reservation: " + reservation);

                //atualização da reserva:

            Console.WriteLine();
            Console.WriteLine("Entre com a data para atualizar a rserva: ");
            checkin = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check out date: (dd/mm/yyyy ");
            checkout = DateTime.Parse(Console.ReadLine());

                               
            reservation.UpdateDates(checkin, checkout);
            Console.WriteLine("Reservation: " + reservation);
            }

            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }


                }

            }
            
            
            

        }
    

