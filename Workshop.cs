using System;
using System.Collections.Generic;
using System.Text;
namespace _8C3_GROUP1{
public class Workshop : ScientificEvent
{
private string track;
private int nbWeeks;
private string[] speakers; // an array
public Workshop(string title, string location, int maxTicket, int ID, string track, int nbWeeks, string[] speakers)
: base(title, location, maxTicket, ID)
{
this.Track = track;
this.NbWeeks = nbWeeks;
this.speakers = speakers;
}
public string Track
{
set
{
if (value.Equals("web design") || value.Equals("programming") || value.Equals("acritical inelegant"))
track = value;
else
throw new Exception("Not valid value"); // it's should be like the value choise
}
get { return track; }
}
public int NbWeeks
{
set
{
if (value > 0)
nbWeeks = value;
else
throw new Exception("The value should be greater than zero");
}
get { return nbWeeks; }
}
public override bool acceptAttendee(Attendee a)
{
if (a.Specialization.Equals(Track))
return true;
else
return false;
}
public override string ToString()
{
return base.ToString() + " Track: " + Track + " Number of weeks:" + NbWeeks;
}
}
}