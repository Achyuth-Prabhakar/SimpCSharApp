﻿using System;

    Console.WriteLine("***** Fun with Basic Data Types *****");

    LocalVarDeclarations();
    DefaultDeclarations();
    NewingDataTypes();
    ObjectFunctionality();
    
   void LocalVarDeclarations()
    {
        Console.WriteLine("=> Data Declarations:");
        // Local variables are declared as so:
        // dataType varName; 
        int myInt = 1;

        string myString;

        myString = "This is my Character Data";


        bool b1 = true, b2 = false, b3 = b1;

        //use System.Boolean datatype to delare a bool.

        bool b4 = false;

        Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);

        Console.WriteLine();
    }

     void DefaultDeclarations()
    {
        Console.WriteLine("=> Default Declarations:");
        int myInt = default;
        Console.WriteLine(myInt);
    }


    void NewingDataTypes()
    {
        Console.WriteLine("=> Using new to create variables:");
        bool b = new();              // Set to false. 
        int i = new();                // Set to 0. 
        double d = new();          // Set to 0. 
        DateTime dt = new DateTime();     // Set to 1/1/0001 12:00:00 AM
        Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
        Console.WriteLine();
    }


   void ObjectFunctionality()
    {
        Console.WriteLine("=> System.Object Functionality:");

        Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());

        Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
     
        Console.WriteLine("12.ToString() = {0}", 12.ToString());
        
        Console.WriteLine("12.GetType() = {0}", 12.GetType());
    
        Console.WriteLine();
}

