using DependencyInjestion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjestion.Services
{
    internal class Work3 : IWork3
    {
        private readonly IWork2 _work2;
        public Work3(IWork2 work2)
        {
            this._work2 = work2;
        }
        public void GetName()
        {
            this._work2.GetName();
            Console.WriteLine("Welcome To IWork 3\n");
        }
    }
}
