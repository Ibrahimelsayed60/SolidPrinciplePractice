using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplePractice.LiskovSubstitution.violate
{
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Flying");
        }
    }

    public class  Ostrich:Bird
    {
        public override void Fly()
        {
            throw new Exception("Ostrich can not fly");
        }
    }
}
