Console.WriteLine("Welcome to your EventPlanner");

//USER INPUTS TO GET ATTRIBUTES FOR THE EVENT CONSTRUCTOR
Console.Write("Please insert the title of the event you wish to plan: ");
string userInputEventTitle = Console.ReadLine();

Console.Write("Please insert the date of the event in format dd/mm/yyyy: ");
string userInputEventDate = Console.ReadLine();

Console.Write("Please insert the number of maximum seats for the event: ");
int userInputMaximumSeats = int.Parse(Console.ReadLine());

//EVENT CONSTRUCTION


Console.WriteLine("How many seats would you like to reserve?");
int userInputSeatsToReserve =  int.Parse(Console.ReadLine());

