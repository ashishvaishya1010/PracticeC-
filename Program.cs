﻿using System;
namespace abc
{
    class Program
    {
       static void Main(string[] args)
        {
            // Demo demo = new Demo();
            // Console.WriteLine(demo.getName());
            // Console.WriteLine(demo.getSum(10, 40));

            // int a=10;
            // int b=20;
            // int c=a+b;
            // int counter =0;
            // while (counter<10)
            // {
            // System.Console.WriteLine(c);

            //  for (int i=0;i<+20;i++){
            //     Console.WriteLine(i);
            //  }
            // var names = new List<string>{"Ashish","Krishna","Akshay","Prajkta"};

            // names.Add("Rushi");
            // names.Add("Shubham");
            // names.Remove("Ashish");

            // names.Sort();
            // foreach(string name in names){
            //     Console.WriteLine(name);
            // }

            // var index =  names.IndexOf("Prajkta");
            // Console.WriteLine(index);
            // for (int i=0;i<names.Count;i++){
            //      Console.WriteLine(names[i]);
            // }

             
             var fibonacciNumbers = new List<int> {1, 1};

while (fibonacciNumbers.Count < 20)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);
}
foreach(var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}

        }

        }
    }
