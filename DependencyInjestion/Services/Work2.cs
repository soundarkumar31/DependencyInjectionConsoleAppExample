using DependencyInjestion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjestion.Services
{
    internal class Work2 : IWork2
    {
        private readonly IWork _work;
        public Work2(IWork work)
        {
            this._work = work;
        }
        public void GetName()
        {
            this._work.GetName();
            Console.WriteLine("Welcome To IWork 2\n");
        }
    }
}
