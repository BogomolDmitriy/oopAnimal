using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Bird
    {
        protected string _name;
        protected string _kind;

        protected string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public void WhatDoesTheBirdDo()
        {
            if (_name == "Giovanni Giorgio")
            {
                Console.WriteLine("He flies on another bird ");
            }
            else
            {
                Console.WriteLine("Bird must be Giovanni Giorgio");
            }
        } 
    }
}
