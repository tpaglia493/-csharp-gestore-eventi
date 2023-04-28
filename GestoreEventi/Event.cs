using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Event
    {
        //ATTRIBUTES
        private string eventTitle;
        private DateTime eventDate;
        private int maximumSeats;
        private int numberOfReservations;

        //CONSTRUCTOR

        public Event(string eventTitle, DateTime eventDate, int maximumSeats ) 
        {
            SetEventTitle(eventTitle);
            SetEventDate(eventDate);
            SetMaximumSeats(maximumSeats);
            numberOfReservations = 0;
        }

        //GETTERS
        public string GetTitle() { return eventTitle; }
     
        public DateTime GetEventDate() { return eventDate; } 
        
        public int GetMaximumSeats() { return maximumSeats; }

        public int GetNumberOfReservations() {  return numberOfReservations; }

        //SETTERS

        public void SetEventTitle(string eventTitle) 
        { 
            if(eventTitle == "")
            {
                throw new ArgumentException("Can't plan an event without a title", "title");
            }
            this.eventTitle = eventTitle;
        }

        public void SetEventDate(DateTime eventDate) 
        {  
            if(eventDate.CompareTo(DateTime.Now) < 0)
            {
                throw new ArgumentException("Can't plan an event for a past date", "eventDate");
            }
            this.eventDate = eventDate;
        }

        private void SetMaximumSeats(int maximumSeats)
        {
            if (maximumSeats < 0)
            {
                throw new ArgumentOutOfRangeException("maximumSeat", "Maximum seats can't be a negative number!");
            }
        }

        //METHODS
        public void reserveSeats(int numberOfSeatsToReserve)
        {
            if (eventDate.CompareTo(DateTime.Now) < 0)
            {
                throw new Exception("Can't reserve seats for a past event!");
            }
            this.numberOfReservations += numberOfSeatsToReserve;
        }
    }
}
