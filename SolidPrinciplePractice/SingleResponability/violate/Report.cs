using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplePractice.SingleResponability.violate
{

    // violate Single Responsability Principle
    public class Report
    {

        public string Title { get; set; }

        public void GenerateReport()
        {
            Console.WriteLine("Generate Report");
        }

        public void SaveFileTo()
        {
            Console.WriteLine("Save file");
        }

        public void SendEmail()
        {
            Console.WriteLine("Send Email");
        }

    }
}
