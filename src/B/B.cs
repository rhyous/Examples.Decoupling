﻿using LibraryB.Interfaces;
using LibraryB.Models;

namespace LibraryB
{
    public class B : IB
    {
        public Something ReturnSomething()
        {
            Console.WriteLine($"{nameof(B)} will return something!");
            return new Something { Id = 27, Title = "Something 27" }; 
        }
    }
}