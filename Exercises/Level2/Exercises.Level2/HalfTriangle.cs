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
        int i, j, lines;
        Console.Write("Input number of Lines : ");
        lines = Convert.ToInt32(Console.ReadLine());
        for (i = 1; i <= lines; i++)
        {
            for (j = 1; j <= i; j++)
            Console.Write("*", j);
            Console.Write("\n");
        }
    return new string[lines];
    }
}
