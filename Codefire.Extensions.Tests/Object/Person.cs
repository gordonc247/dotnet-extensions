﻿using System;

namespace Codefire.Extensions.Tests
{
    public class Person
    {
        public string Name { get; set; }
        public bool IsEmployed { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Age { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
