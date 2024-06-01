using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarManagement
{
    public class Car
    {
        //declare the field
        public string make;
        public string model;
        public string color;
        public int yearBuilt;
        //define the methods
        public void Start(){
            System.Console.WriteLine(model + " started");
        }
        public void Stop(){
            System.Console.WriteLine(model + " stopped");
        }
    }
}