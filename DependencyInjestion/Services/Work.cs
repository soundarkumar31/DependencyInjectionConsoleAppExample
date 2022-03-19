using DependencyInjestion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjestion.Services
{
    internal class Work : IWork
    {
        public void GetName()
        {
            Console.WriteLine("Welcome To IWork\n");
        }
    }
}
