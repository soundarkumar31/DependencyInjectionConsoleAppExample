using DependencyInjestion.Interfaces;
using DependencyInjestion.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper.DisplayServiceNames();

            Console.ReadLine();
        }
    }
}
