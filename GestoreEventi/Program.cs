using GestoreEventi;

Console.WriteLine( "Welcome to your EventPlanner\n");

//CREATING A PROGRAM OF EVENTS

    //GET EVENT PROGRAM NAME FROM USER
Console.Write("\nPlease insert the name of the program of events you want to create: ");
string userInputProgramTitle = Console.ReadLine();

EventProgram newProgramOfEvents = new EventProgram(userInputProgramTitle);

    //GET NUMBER OF EVENTS TO PLAN FROM USER
Console.Write("\nHow many events do you want to plan for this program? ");
int userInputNumberOfEvents = 0;
try { 
userInputNumberOfEvents = int.Parse(Console.ReadLine());
}
catch(Exception e)  //IN CASE OF ERROR 
{ 
    
    bool validated= false;
    while (!validated)      //GET AND VALIDATE A NEW NUMBER OF EVENTS FROM USER
    {
        Console.WriteLine(e.ToString());
        Console.Write("\nHow many events do you want to plan for this program? ");
        Console.Write("\nPlease insert a number: ");
        string numberToCheck = Console.ReadLine();
        bool isANumber = int.TryParse(numberToCheck, out userInputNumberOfEvents);
        if (isANumber)
        {
            //userInputNumberOfEvents = int.Parse(numberToCheck);
            validated = true;
        }
    }
}

//CREATE A NUMBER OF EVENTS SAME AS NUMBER FROM USER INPUT AND ADD THEM TO THE LIST OF EVENTS
for (int i = 0; i < userInputNumberOfEvents; i++)
{
//EVENT CONSTRUCTION
    Event newEvent = new Event();

    //USER INPUTS TO GET ATTRIBUTES FOR THE EVENT CONSTRUCTOR

//GET NAME OF EVENT FROM USER INPUT
    Console.Write("\nPlease insert the title of the event you wish to plan: ");
    string userInputEventTitle = Console.ReadLine();
    newEvent.SetEventTitle(userInputEventTitle);

//GET DATE TIME OF EVENT FROM USER INPUT AND VALIDATE INPUT
    Console.Write("Please insert the date of the event in format dd/mm/yyyy: ");
    DateTime userInputEventDate = DateTime.Now;
    try
    {
        userInputEventDate = DateTime.Parse(Console.ReadLine());

    }
    catch (Exception e)     //IN CASE OF ERROR
    {
        
        bool validated = false;
        while (!validated)      //GET AND VALIDATE A NEW DATE TIME FROM USER
        {
            Console.WriteLine(e.ToString());
            Console.Write("\nPlease insert the date in the right format dd/mm/yyyy: ");
            string DateToCheck = Console.ReadLine();
            bool isADate = DateTime.TryParse(DateToCheck, out userInputEventDate);
            if (isADate)
            {
                validated = true;
            }
        }
    }
    try
    {
        newEvent.SetEventDate(userInputEventDate);
    }
    catch (ArgumentException e) //IN CASE OF ERROR
    {
                bool validated = false;
        while (!validated)      //GET AND VALIDATE A NEW DATE TIME FROM USER
        {
            Console.WriteLine(e.ToString());
            Console.Write("\nPlease insert a valid date in the right format dd/mm/yyyy: ");
            string DateToCheck = Console.ReadLine();
            bool isADate = DateTime.TryParse(DateToCheck, out userInputEventDate);
            if (isADate && userInputEventDate.CompareTo(DateTime.Now) >=0)
            {
                newEvent.SetEventDate(userInputEventDate);
                    validated = true;
              
            }
        }
    }

//GET MAXIMUM NUMBER OF SEATS FOR THE EVENT
    Console.Write("Please insert the number of maximum seats for the event: ");
    int userInputMaximumSeats = int.Parse(Console.ReadLine());
    try
    {
        newEvent.SetMaximumSeats(userInputMaximumSeats);
    }
    catch (ArgumentException e)  //IN CASE OF ERROR
    {

        bool validated = false;
        while (!validated)      //GET AND VALIDATE A NEW NUMBER OF SEATS FROM USER
        {
            Console.WriteLine(e.ToString());
            Console.Write("\nPlease insert a valid number of seats for the event: ");
            string numberToCheck = Console.ReadLine();
            bool isANumuber = int.TryParse(numberToCheck, out userInputMaximumSeats);
            if (isANumuber)
            {
                validated = true;
            }
        }
    }
//ADD EVENT TO EVENT PROGRAM LIST
    newProgramOfEvents.AddEvent(newEvent);
}

Console.WriteLine($"\nYour program contains {newProgramOfEvents.GetNumberOfEvents()} events");
Console.WriteLine(newProgramOfEvents.ToString());
Console.Write("\nInsert a date to check if there are events on that day: ");
DateTime eventDateFromUser = DateTime.Now;
try
{
    eventDateFromUser = DateTime.Parse(Console.ReadLine());
}
catch (Exception e)     //IN CASE OF ERROR
{

    bool validated = false;
    while (!validated)      //GET AND VALIDATE A NEW DATE TIME FROM USER
    {
        Console.WriteLine(e.ToString());
        Console.Write("\nPlease insert the date in the right format dd/mm/yyyy: ");
        string DateToCheck = Console.ReadLine();
        bool isADate = DateTime.TryParse(DateToCheck, out eventDateFromUser);
        if (isADate)
        {
            validated = true;
        }
    }
}
    List<Event> eventsOnSameDate = newProgramOfEvents.GetEventsInSameDate(eventDateFromUser);
EventProgram.PrintListOfEvents(eventsOnSameDate);
newProgramOfEvents.ClearActualListOfEvents();

/*****************************************************************************************************************************
//USER INTERFACE

//SEATS RESERVATION
Console.WriteLine($"Would you like to reserve seats for the event '{newEvent.GetTitle()}'?");
string userWantsToReserve = Console.ReadLine().ToUpper();
if (userWantsToReserve == "SI" || userWantsToReserve == "YES" || userWantsToReserve == "Y" || userWantsToReserve == "SÌ" || userWantsToReserve == "S")
{
    Console.WriteLine("How many seats would you like to reserve?");
    int userInputSeatsToReserve =  int.Parse(Console.ReadLine());
    newEvent.reserveSeats(userInputSeatsToReserve);
}

Console.WriteLine($"\nThe maximum capacity for the event is of {newEvent.GetMaximumSeats()} seats");
Console.WriteLine($"The number of actual reservations is {newEvent.GetNumberOfReservations()}");
Console.WriteLine($"There are now {newEvent.GetMaximumSeats() - newEvent.GetNumberOfReservations()} remaining seats");



//CANCEL RESERVATIONS
bool userWantsToCancel = true;
while (userWantsToCancel)
{
    Console.WriteLine($"\nWould you like to cancel reservations for the event '{newEvent.GetTitle()}'?");
    string userAnswer = Console.ReadLine().ToUpper();
    if (userAnswer == "SI" || userAnswer == "YES" || userAnswer == "Y" || userAnswer == "SÌ" || userAnswer == "S")
    {
        Console.WriteLine("\nHow many reservations would you like to cancel?");
        int userInputReservationsToCancel = int.Parse(Console.ReadLine());
        newEvent.cancelReservations(userInputReservationsToCancel);
        Console.WriteLine($"\nThe number of actual reservations is {newEvent.GetNumberOfReservations()}");
        Console.WriteLine($"There are now {newEvent.GetMaximumSeats() - newEvent.GetNumberOfReservations()} remaining seats");
    }
    else { 
        userWantsToCancel = false;
        Console.WriteLine("Thank you");
    }

}
*******************************************************************************************************************************/
