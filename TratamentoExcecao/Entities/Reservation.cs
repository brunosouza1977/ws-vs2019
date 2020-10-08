using System;
using System.Collections.Generic;
using System.Text;
using TratamentoExcecao.Entities.Exceptions;

namespace TratamentoExcecao.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            //realizando tratamento no construtor para que não seja criada uma reserva
            if (checkout <= checkin)
            {
                throw new DomainException("Checkout date must be after checkin");
            }

            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            //função TimeSpan calcula o intervalo de tempo entre datas
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;

        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if(checkin < now || checkout < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            if(checkout <= checkin)
            {
                throw new DomainException("Checkout date must be after checkin");
            }

            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return "Room"
                + RoomNumber
                + ", check-in: "
                + Checkin.ToString("dd/MM/yyyy")
                + ", check out: "
                + Checkout.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";



        }


    }
}
