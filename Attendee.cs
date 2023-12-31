using System;
using System.Collections.Generic;
using System.Text;
namespace _8C3_GROUP1 {
public class Attendee
{
private string name;
private int age;
private string specialization;
private int id;
public Attendee(string name, int age, string specialization, int id)
{
this.Name = name;
this.Age = age;
this.Specialization = specialization;
this.Id = id;
}
public string Name
{
set
{
if (value != "")
name = value;
else
throw new Exception("Error, The name must be not null");
}
get { return name; }
}
public int Age
{
set
{
if (value > 0)
age = value;
else
throw new Exception("Error, The age must be greater than zero");
}
get { return age; }
}
public string Specialization
{
set
{
if (value.Equals("web design") || value.Equals("programming") || value.Equals("acritical inelegant"))
6 | P a g e
specialization = value;
else
throw new Exception("Error, wrong value "); // must be string
}
get { return specialization; }
}
public int Id
{
set
{
if (value > 0)
id = value;
else
throw new Exception("Error, The ID must be greater than zero ");
}
get { return id; }
}
public override string ToString()
{
return "Name: " + Name + " Age: " + Age + " ID: " + Id + " Specialization: " + Specialization;
}
}
}