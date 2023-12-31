using System;
using System.Collections.Generic;
using System.Text;
namespace _8C3_GROUP1{
//abstact class
public abstract class ScientificEvent
{
private string title;
private string location;
private int maxTicket;
private int ID;
Attendee[] atds; // an array of type attendee
int counter = 0;
public ScientificEvent(string title, string location, int maxTicket, int ID)
{
this.Title = title;
this.Location = location;
this.MaxTicket = maxTicket;
this.Id = ID;
atds = new Attendee[MaxTicket];
}
public string Title
{
set
{
if (value != null)
title = value;
else
throw new Exception("Error, The title to be valid must be not null");
}
get { return title; }
}
public string Location
{
get { return location; }
set
{
if (value != null)
location = value;
else
throw new Exception("Error,The location to be valid must be not null");
}
}
8 | P a g e
public int MaxTicket
{
set
{
if (value > 0)
maxTicket = value;
else
throw new Exception("Error,The value to be valid must be greater than zero");
}
get { return maxTicket; }
}
public int Id
{
set
{
if (value > 0)
ID = value;
else
throw new Exception("Error,The value to be valid must be greater than zero");
}
get { return ID; }
}
public abstract bool acceptAttendee(Attendee a);
public void addAttendee(Attendee a)
{
bool exists = false;
if (counter < atds.Length)
{
for (int i = 0; i < counter; i++)
{
if (a.Id == atds[i].Id)
{
exists = true;
Console.WriteLine("This attendee is already exists");
break;
}
}
if (!exists && acceptAttendee(a) == true)
{
atds[counter] = a;
counter++;
Console.WriteLine("Reservation successful");
}
else
Console.WriteLine("Error, there are a problem with the reservation process");
}
else
Console.WriteLine("Error, the event full...");
}
public bool removeAttendee(Attendee a)
{
bool exists = false;
for (int i = 0; i < counter; i++)
9 | P a g e
{
if (a.Id == atds[i].Id)
{
atds[i] = null;
exists = true;
}
}
return exists;
}
public override string ToString()
{
return String.Format("Title: {0}, Location: {1}, ID: {2}, Number of Attendances is: {3} "
, Title, Location, Id, MaxTicket);
}
}
}