using System;

class Program {
  public static void Main (string[] args) {
    Employee unknown = new Employee();//constructor with no parameters
    unknown.Intro();

    Employee john = new Employee("John","Smith","1234",45);
    john.Intro();
  }
}