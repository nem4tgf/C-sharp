using CarManagement;

class Program
{
 public static void MainO()
 {
    //declare a Car object reference named myCar
    Car myCar;
    //create a Car object, and assign its address to myCar
    System.Console.WriteLine("Creating a Car object and assigning " + "its memory location to myCar");
    myCar = new Car();
    
    //assign values to the Car object's fields using myCar
    myCar.make = "Toyota";
    myCar.model = "MR2";
    myCar.color ="black";
    myCar.yearBuilt = 1995;

    //display the field values suing myCar
    System.Console.WriteLine("myCar details: ");
    System.Console.WriteLine("myCar.make = " +myCar.make);
    System.Console.WriteLine("myCar.model = " +myCar.model);
    System.Console.WriteLine("myCar.color = " +myCar.color);
    System.Console.WriteLine("myCar.yearBuilt = " +myCar.yearBuilt);

    //call the methods using myCar
    myCar.Start();
    myCar.Stop();

    //declare another Car object reference and 
    //create another Car object
 }   
}