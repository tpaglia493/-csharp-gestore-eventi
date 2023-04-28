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
bool userWantsToReserve = true;

while (userWantsToReserve) 
{ 
    Console.WriteLine($"Would you like to reserve seats for the event '{newEvent.GetTitle()}'?");
    string userAnswer = Console.ReadLine().ToUpper();
    Console.WriteLine(userAnswer);
    if (userAnswer != "SI" && userAnswer != "YES" && userAnswer != "Y" && userAnswer != "SÌ" && userAnswer != "S")
    {
        userWantsToReserve = false;
    }
Console.WriteLine("How many seats would you like to reserve?");
int userInputSeatsToReserve =  int.Parse(Console.ReadLine());
}
Console.WriteLine(newEvent.ToString());

