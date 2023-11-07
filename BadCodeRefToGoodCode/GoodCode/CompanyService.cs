namespace GoodCode
{
    public class CompanyService
    {
        public List<Company> GetCompanies()
        {

            return new List<Company>
            {
                new Company{ Name="acme", HourlyPrice=150},
                new Company{ Name="abc", HourlyPrice=125},

            };
        }


        public void SendMailToCompanies(List<TimeSheetEntry> timeSheetEntries)
        {
            var calculator = new TimeSheetBillCalculator();
            var companies = GetCompanies();
            var mailSender = new MailSender();
            companies.ForEach(company =>
            {
                var totalPayment = calculator.TotalHoursInAWeekForCompany(timeSheetEntries, company.Name);
                mailSender.SendMail(timeSheetEntries, company, totalPayment);
            });
        }


    }
}
