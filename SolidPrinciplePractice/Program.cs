using SolidPrinciplePractice.DependencyInversion.Correct;
using SolidPrinciplePractice.InterfaceSegregation.Correct;
using SolidPrinciplePractice.LiskovSubstitution.Correct;
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


            #region Liskov Substitution

            List<IFlying> birds = new List<IFlying>()
            {
                new Sparrow()
            };

            foreach (var bird in birds)
            {
                bird.Fly();
            }

            List<Bird> allBirds = new List<Bird>
            {
                new Sparrow { Name = "Jack" },
                new Ostrich { Name = "Oscar" }
            };

            foreach (var bird in allBirds)
            {
                Console.WriteLine($"{bird.Name} is a bird.");
            }

            #endregion


            #region Interface Segregation

            List<IWorkable> workers = new List<IWorkable>
            {
                new Human(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            List<IEatable> eaters = new List<IEatable>
            {
                new Human()
            };

            foreach (var eater in eaters)
            {
                eater.Eat();
            }

            #endregion

            #region Dependency Inversion

            IMessageSender sender = new EmailSender();  
            NotificationService notification = new NotificationService(sender);

            notification.Notify("Welcome to our system!");

            #endregion

        }
    }
}
