using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplePractice.LiskovSubstitution.Correct
{
    public abstract class Bird
    {
        public string Name { get; set; }
    }

    public interface IFlying
    {
        public void Fly();
    }

    public class Sparrow : Bird, IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Sparrow flying");
        }
    }

    public class Ostrich: Bird
    {
        public void Run()
        {
            Console.WriteLine("Ostrich is running");
        }
    }

}
