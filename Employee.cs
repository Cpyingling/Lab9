/*Author Charlie Yingling*/
using System;

//Add a new class called Employee in Employee.cs
class Employee {
//fields
  private string firstname;
  private string lastname;
  private string id;
  private string address;
  private string phonenumber;
  private string title;
  private string employmentstatus;
  private double yearlysalary;
  private int age;


  public Employee() { //constructor with no parameters
    firstname="unknown";
    lastname="unknown";
    id="unknown";
    age=0;
    employmentstatus="active";
    Console.WriteLine("A new employee object has been created!");
  }
  public Employee(string employeefirst, string employeelast, string employeeid, int employeeage) { //constructor with 4 parameters
    firstname = employeefirst;
    lastname = employeelast;
    id = employeeid;
    age = employeeage;
    employmentstatus = "active";
    Console.WriteLine("A new employee object has been created!");
  }
  public void Intro() {
    Console.WriteLine("My first name is " + firstname);
    Console.WriteLine("My last name is " + lastname);
    Console.WriteLine("My ID is " + id);
    Console.WriteLine("My age is " + age);
    Console.WriteLine("My employmentstatus is " + employmentstatus);
  }
}