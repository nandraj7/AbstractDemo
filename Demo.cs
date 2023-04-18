using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    abstract public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
         
        public void Show(float a, int b)   
        {

        }

        abstract public void Display();      //Abstract Method
         
       
        virtual public void GetData()    //Non Abstract Method  
        {

        }

        public void PutData()
        {

        }

    }

    public class Teacher : Person
    { 
        
        public string Degree { get; set; }

        public void Show(int a, float b)         //Method Overloading
        {

        }

        public override void GetData()      //Method Overriding
        {

        }

        public override void Display()      //Abstrct Method Implementation
        {
               
        }

        public new void PutData()           //1 Method Overloading
        {                                   //2 Method Overriding
                                            //3 Abstrct Method Implementation
        }                                   //4 Method Hiding/Showding Use Of New Keyword

    }

    public class Student : Person
    {
        public double AggregateMarks { get; set; }
        public override void Display()
        {

        }

    }

    public class Employee : Person
    {
        public int Bonus { get; set; }
        public override void Display()
        {

        }

    }

    public class Doctor : Person
    {
        public int NoOfSurgeriesPerformed { get; set; }
        public override void Display()
        {

        }
   
    }


}
