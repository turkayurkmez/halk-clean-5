namespace GoodCode
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TimeSheetEntry> timeSheetEntries = loadEntriesFromUser();

            CompanyService companyService = new CompanyService();
            companyService.SendMailToCompanies(timeSheetEntries);
            TimeSheetBillCalculator timeSheetBillCalculator = new TimeSheetBillCalculator();
            var payment = timeSheetBillCalculator.GetBillForExtraTime(timeSheetEntries, standardHoursForAWeek: 40);
            Console.WriteLine($"You will get paid $ {payment} for your work.");
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }

        static List<TimeSheetEntry> loadEntriesFromUser()
        {
            List<TimeSheetEntry> timeSheetEntries = new List<TimeSheetEntry>();
            string answer = string.Empty;
            do
            {
                Console.Write("Enter what you did: ");
                string workDone = Console.ReadLine();
                double timeForWork = getTimeForWorkFromUser();
                TimeSheetEntry timeSheetEntry = new TimeSheetEntry
                {
                    HoursWorked = timeForWork,
                    WorkDone = workDone
                };
                timeSheetEntries.Add(timeSheetEntry);
                Console.Write("Do you want to enter more time (yes/no): ");
                answer = Console.ReadLine();

            } while (answer.ToLower() == UserAnswers.YES);

            return timeSheetEntries;
        }

        private static double getTimeForWorkFromUser()
        {
            bool isParsedToBoolean = false;
            double timeForWork;
            do
            {
                Console.Write("How long did you do it for: ");
                string rawTimeWorked = Console.ReadLine();
                isParsedToBoolean = double.TryParse(rawTimeWorked, out timeForWork);
                if (!isParsedToBoolean)
                {
                    Console.WriteLine("Invalid number given!");
                }

            } while (!isParsedToBoolean);


            return timeForWork;
        }
    }
}