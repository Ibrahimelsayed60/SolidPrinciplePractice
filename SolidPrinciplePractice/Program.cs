using SolidPrinciplePractice.OpenClosedPrinciple.Correct;
using SolidPrinciplePractice.SingleResponability.Correct;

namespace SolidPrinciplePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Single Responsability

            var reportService = new ReportService();
            var fileManager = new FileManager();
            var emailService = new EmailService();

            var report = reportService.GenerateReport();

            emailService.SendEmail(report);

            fileManager.SaveToFile(report);

            #endregion

            #region Open/Closed Principle

            var processor = new PaymentProcessor();

            processor.Process(new CreditCardPayment());
            processor.Process(new PaypalPayment());

            #endregion
        }
    }
}
