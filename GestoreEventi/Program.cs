using GestoreEventi;

Console.WriteLine( "Welcome to your EventPlanner\n");

//CREATING A PROGRAM OF EVENTS

    //GET EVENT PROGRAM NAME FROM USER
Console.Write("\nPlease insert the name of the program of events you want to create: ");
string userInputProgramTitle = Console.ReadLine();
EventProgram newProgram = new EventProgram(userInputProgramTitle);

    //GET NUMBER OF EVENTS TO PLAN FROM USER
Console.Write("\nHow many events do you want to plan for this program?");
int userInputNumberOfEvents=0;
try { 
userInputNumberOfEvents = int.Parse(Console.ReadLine());
}
catch(Exception e)  //IN CASE OF ERROR 
{ 
    Console.WriteLine(e.ToString());
    bool validated= false;
    while (!validated)      //GET AND VALIDATE A NEW NUMBER OF EVENTS FROM USER
    {
        Console.Write("\nPlease insert a number:");
        string numberToCheck = Console.ReadLine();
        bool isANumber = int.TryParse(numberToCheck, out userInputNumberOfEvents);
        if (isANumber)
        {
            userInputNumberOfEvents = int.Parse(numberToCheck);
            validated = true;
        }
    }
}


for(int i= 0; i<userInputNumberOfEvents;) {
//EVENT CONSTRUCTION
Event newEvent = new Event();

    //USER INPUTS TO GET ATTRIBUTES FOR THE EVENT CONSTRUCTOR

    //GET NAME OF EVENT FROM USER INPUT
    Console.Write("Please insert the title of the event you wish to plan: ");
string userInputEventTitle = Console.ReadLine();
   newEvent.SetEventTitle(userInputEventTitle);

    //GET DATE TIME OF EVENT FROM USER INPUT
Console.Write("Please insert the date of the event in format dd/mm/yyyy: ");
DateTime userInputEventDate = new DateTime();   
    try 
    { 
        userInputEventDate = DateTime.Parse(Console.ReadLine());
       
    }
    catch (Exception e)     //IN CASE OF ERROR
    {
        Console.WriteLine(e.ToString());
        bool validated = false;
        while (!validated)      //GET AND VALIDATE A NEW DATE TIME FROM USER
        {
            Console.Write("\nPlease insert the date in the right format dd/mm/yyyy:");
            string DateToCheck = Console.ReadLine();
            bool isADate = DateTime.TryParse(DateToCheck, out userInputEventDate);
            if (isADate)
            {
                userInputEventDate = DateTime.Parse(DateToCheck);
                validated = true;
            }
        }
    }
  try { 
        newEvent.SetEventDate(userInputEventDate); 
    }catch(ArgumentException e)
    {
        Console.WriteLine(e.ToString());
        bool validated = false;
        while (!validated)      //GET AND VALIDATE A NEW DATE TIME FROM USER
        {
            Console.Write("\nPlease insert a valid date in the right format dd/mm/yyyy:");
            string DateToCheck = Console.ReadLine();
            bool isADate = DateTime.TryParse(DateToCheck, out userInputEventDate);
            if (isADate)
            {
             DateTime DateChecked = DateTime.Parse(DateToCheck);
                if (DateChecked.CompareTo(DateTime.Now) >= 0) 
                { 
                    newEvent.SetEventDate(DateChecked);
                    validated = true; 
                }
            }          
        }
    }


Console.Write("Please insert the number of maximum seats for the event: ");
int userInputMaximumSeats = int.Parse(Console.ReadLine());


    //ADD EVENT TO EVENT PROGRAM LIST
    newProgram.AddEvent(newEvent);

}

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
