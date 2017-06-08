using System;
using GitDemo.Utility;
namespace GitDemo
{
public static class MyClass
{
    public static void Main(){


        Console.WriteLine("Hello World");
string someName = "Santa"
        Console.WriteLine("Enter your first name.");
        String myName = Utility.GetFirstName();//Console.ReadLine();
        Console.WriteLine("Enter your last name");
        String lastName = Utility.GetlastName();// Console.ReadLine();
        if (MyName=="")
        {
        Console.WriteLine("hello, {0}", someName);
        
        }

        

        if (lastName == "")
        {
        
        Console.WriteLine("hello {0}", myName);
        }
        Console.WriteLine("hello {0} {1}", myName, lastName);



    
    }


}
}