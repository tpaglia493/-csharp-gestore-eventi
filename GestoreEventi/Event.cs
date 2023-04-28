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
        private string title;
        private DateTime eventDate;
        private int maximumSeats;
        private int numberOfReservations;

        //CONSTRUCTOR

        //GETTERS
        public string GetTitle() { return title; }
     
        public DateTime GetEventDate() { return eventDate; } 
        
        public int GetMaximumSeats() { return maximumSeats; }

        public int GetNumberOfReservations() {  return numberOfReservations; }

        //SETTERS

        public void SetTitle(string title) { this.title = title;}

        public void SetEventDate(DateTime eventDate) {  this.eventDate = eventDate;}

        //METHODS

    }
}
