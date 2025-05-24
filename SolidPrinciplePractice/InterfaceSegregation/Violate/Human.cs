using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplePractice.InterfaceSegregation.Violate
{

    public interface IWorker
    {
        void Eat();
        void work();
    }

    public class Human : IWorker
    {
        public void Eat()
        {
            Console.WriteLine("Eating.....");
        }

        public void work()
        {
            Console.WriteLine("Working......");
        }
    }

    public class Robot : IWorker
    {
        public void Eat()
        {
            Console.WriteLine("Eating.....");
        }

        public void work()
        {
            throw new NotImplementedException();
        }
    }
}
