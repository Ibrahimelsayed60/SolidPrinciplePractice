using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplePractice.SingleResponability.Correct
{
    public class Report
    {

        public string Title { get; set; }

        public string Content { get; set; }

    }

    public class ReportService
    {
        public Report GenerateReport()
        {
            return new Report { Title = "Sales", Content = "Sales data..." };
        }
    }

    public class FileManager
    {
        public void SaveToFile (Report report)
        {
            File.WriteAllText("report.txt", report.Content);
            Console.WriteLine("Report saved.");
        }
    }

    public class EmailService
    {
        public void SendEmail(Report report)
        {
            Console.WriteLine($"Sending {report.Title} report via email...");
            // simulate sending
            Console.WriteLine("Report sent.");
        }
    }
}
