using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplePractice.InterfaceSegregation.Correct
{

    public interface IWorkable
    {
        void Work();
    }

    public interface IEatable
    {
        void Eat();
    }

    public class Human : IWorkable, IEatable
    {
        public void Eat()
        {
            Console.WriteLine("Eating....");
        }

        public void Work()
        {
            Console.WriteLine("Working....");
        }
    }

    public class Robot : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Working.....");
        }
    }
}
