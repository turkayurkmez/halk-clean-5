namespace GoodCode
{
    public class MailSender
    {
        public void SendMail(List<TimeSheetEntry> timeSheetEntries, Company company, double totalHoursInAWeek)
        {


            Console.WriteLine($"Simulating Sending email to {company.Name} ");
            Console.WriteLine("Your bill is $" + (totalHoursInAWeek * company.HourlyPrice) + " for the hours worked.");
        }
    }
}
