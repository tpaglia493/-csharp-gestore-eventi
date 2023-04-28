using GestoreEventi;

Console.WriteLine( "Welcome to your EventPlanner");

//USER INPUTS TO GET ATTRIBUTES FOR THE EVENT CONSTRUCTOR
Console.Write("Please insert the title of the event you wish to plan: ");
string userInputEventTitle = Console.ReadLine();

Console.Write("Please insert the date of the event in format dd/mm/yyyy: ");
DateTime userInputEventDate = DateTime.Parse(Console.ReadLine());

Console.Write("Please insert the number of maximum seats for the event: ");
int userInputMaximumSeats = int.Parse(Console.ReadLine());

//EVENT CONSTRUCTION

Event newEvent = new Event(userInputEventTitle, userInputEventDate, userInputMaximumSeats);


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

