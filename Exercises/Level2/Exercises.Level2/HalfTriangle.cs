using System;

namespace Exercises.Level2;
public class HalfTriangle
{
    /// <summary>
    /// The program:
    ///  You must create a half triangle. 
    ///  n is the number of lines a triangle will have.
    ///  Triangle body has to be made out of "*",
    ///  so result should for 3 be like:
    ///* 
    ///***
    ///*****
    /// 
    /// Example of 5:
    /// 
    ///*
    ///***
    ///*****
    ///*******
    ///*********
    ///
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public string[] GetHalfTriangle(int n)
    {
        int NumOfLines = 5;
        for (int i = 0; i < NumOfLines; i++)
        {
            for (int j = 0; j < n - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k <= i; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
        throw new ();
    }
}
