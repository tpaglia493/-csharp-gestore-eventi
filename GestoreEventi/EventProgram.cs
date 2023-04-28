using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class EventProgram
    {
        //ATTRIBUTES
        private string programTitle;
        private  List<Event> events;
        //CONSTRUCTOR
        public EventProgram(string programTitle)
        {
            this.programTitle = programTitle;
            events = new();
        }

        //GETTERS

        //SETTERS

        //METHODS

        public void AddEvent(Event newEvent) 
        { 
            events.Add(newEvent);
        }

        public List<Event> GetEventsInSameDate(DateTime specificDate)
        {
            List<Event> eventsInSpecificDate = new List<Event>();
            foreach (Event anyEvent in this.events) 
            {
                if(specificDate.CompareTo(anyEvent.GetEventDate()) == 0)
                {
                    eventsInSpecificDate.Add(anyEvent);
                }
            }
            return eventsInSpecificDate;
        }

        public static void PrintListOfEvents(List<Event> anyListOfEvents) 
        {
            string info = $"Events in program for {nameof(anyListOfEvents)}";
            foreach (Event anyEvent in anyListOfEvents)
            {

                info += anyEvent.ToString();
            }
            Console.WriteLine(info);
        }

        public void ClearActualListOfEVents() { events.Clear(); }

        public int GetNumberOfEvents() { return events.Count; }

        public override string ToString()
        {
            string info = $"---------- {this.programTitle} ----------";
            foreach (Event anyEvent in events)
            {
                info += anyEvent.ToString();
            }
            info += "--------------------------------------";
            return info;
        }
    }
}
