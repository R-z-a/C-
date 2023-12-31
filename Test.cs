using System;
namespace _8C3_GROUP1
{
class Test {
static void Main(string[] args)
{
Console.WriteLine(" Enter the size of the event list: ( how many event) ");
int size = Convert.ToInt32(Console.ReadLine());
// from class ScientificEvent
ScientificEvent[] Events = new ScientificEvent[size];
// to have a count
int EventCounter = 0;
int Choice = 0;
// when choise are not equale 5 let's go to the menu becasue 5 mean exit
while (Choice != 5)
{
Console.WriteLine("❤️❤️❤️The menu ❤️❤️❤️");
Console.WriteLine("1- Add a new workshop to the array, and add all attendances." +
"\n2- Add a new training to the array, and add all attendances." +
"\n3- Print the sum of maximum number of attendances (maxTicket) in all the workshops." +
"\n4- Print the information of all training events that have the same professor's name." +
"\n5- Exit");
Console.WriteLine("------------------------------------------------------------");
Choice = Convert.ToInt32(Console.ReadLine());
// 5 cases
switch (Choice)
{
// Add a workshop to the array, and add all attendances
case 1:
// start user wirte
Console.WriteLine("Enter The Title Of The Event:");
string title = Console.ReadLine();
Console.WriteLine("Enter The Location Of The Event:");
string location = Console.ReadLine();
Console.WriteLine("Enter The Maximum Number for The Ticket Of The Event:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The Id Of The Event:");
int id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The Track Name:");
string track = Console.ReadLine();
Console.WriteLine("Enter The Number Of Weeks:");
int nbWeeks = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The Number Of Speakers In This Workshop:");
int nbSpeakers = Convert.ToInt32(Console.ReadLine());
// end user write
string[] speakers = new string[nbSpeakers];
Workshop workshop = new Workshop(title, location, max, id, track, nbWeeks, speakers);
// start user wirte
Console.WriteLine(" Enter the Number Of Attendances In This Workshop: ( how many attendances)");
int AttendeCounter = Convert.ToInt32(Console.ReadLine());
// end user wirte
if (AttendeCounter < max)
{
for (int i = 0; i < AttendeCounter; i++)
{
// start user wirte
Console.WriteLine("Enter The Attendee Name:");
string name = Console.ReadLine();
Console.WriteLine("Enter The Attendee Age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The Attendee Specialization:");
string specialization = Console.ReadLine();
Console.WriteLine("Enter The Attendee ID:");
int ID = Convert.ToInt32(Console.ReadLine());
// end user wirte
workshop.addAttendee(new Attendee(name, age, specialization, ID));
}
}
else
Console.WriteLine("Error, The Number of attendee must be Less Than " + max);
if (EventCounter < size)
{
Events[EventCounter] = workshop;
EventCounter++;
}
else
Console.WriteLine(" The Event are Full...");
break;
case 2: // Add a new training to the array, and add all attendances
// start user wirte
Console.WriteLine("Enter The Title Of The Event:");
title = Console.ReadLine();
Console.WriteLine("Enter The Location Of The Event:");
location = Console.ReadLine();
Console.WriteLine("Enter The Maximum Number for The Ticket Of The Event:");
max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The Id Of The Event:");
id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The Professor's Name For This Training:");
string Pname = Console.ReadLine();
// end user wirte
Training training = new Training(title, location, max, id, Pname);
// start user wirte
Console.WriteLine("Enter The Number of Attendees For This Training:");
AttendeCounter = Convert.ToInt32(Console.ReadLine());
// end user wirte
if (AttendeCounter < max)
{
for (int i = 0; i < AttendeCounter; i++)
{
Console.WriteLine("Enter The Attendee Name:");
string name = Console.ReadLine();
Console.WriteLine("Enter The Attendee Age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The Attendee Specialization:");
string specialization = Console.ReadLine();
Console.WriteLine("Enter The Attendee ID:");
int attendee_ID = Convert.ToInt32(Console.ReadLine());
training.addAttendee(new Attendee(name, age, specialization, attendee_ID));
}
}
else
Console.WriteLine(" The Number of attendee must be Less Than : " + max); //list full
if (EventCounter < size)
{
Events[EventCounter] = training;
EventCounter++;
}
else
Console.WriteLine("The Event are Full...");
break;
case 3: // Print the sum of maximum number of attendances in all the workshops.
int sum = 0;
for (int i = 0; i < Events.Length; i++)
{
if (Events[i] is Workshop)
sum += Events[i].MaxTicket;
}
Console.WriteLine("The Sum Of Maximum Number Of Attendances In All The Workshops = " + sum);
break;
case 4: // Print the information of all training events that have the same professor's name
Console.WriteLine(" Enter The Professor Name: ");
Pname = Console.ReadLine();
for (int i = 0; i < Events.Length; i++)
{
if (Events[i] is Training)
{
Training t = (Training)Events[i];
if (t.ProfName.Equals(Pname))
Console.WriteLine(t);
}
}
break;
case 5:
Console.WriteLine("thanks");
Environment.Exit(0); // to exit from program
break;
default:
Console.WriteLine("Invalid Choice!...");
break;
}
}
Console.ReadKey();
}
}
}