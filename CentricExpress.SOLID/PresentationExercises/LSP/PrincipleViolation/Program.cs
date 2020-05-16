using System;

namespace PresentationExercises.LSP.PrincipleViolation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Orange();
            Console.WriteLine(apple.GetColor());
        }
    }
}