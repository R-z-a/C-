sing System;
using System.Collections.Generic;
using System.Text;
namespace _8C3_GROUP1
{
public class Training : ScientificEvent
{
private string profName;
public Training(string title, string location, int maxTicket, int ID, string profName) : base(title, location, maxTicket, ID)
{
this.ProfName = profName;
}
public string ProfName
{
set { profName = value; }
get { return profName; }
}
public override bool acceptAttendee(Attendee a)
{
if (a.Age > 12)
return true;
else
return false;
}
public override string ToString()
{
return base.ToString() + " Professor Name: " + ProfName;
}
}
}