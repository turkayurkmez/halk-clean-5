namespace GoodCode
{
    public class TimeSheetBillCalculator
    {
        public double GetBillForExtraTime(List<TimeSheetEntry> timeSheetEntries, int standardHoursForAWeek)
        {
            double totalHoursInAWeek = timeSheetEntries.Sum(x => x.HoursWorked);

            int extraPayment = 15;
            int standardPayment = 10;
            if (totalHoursInAWeek > standardHoursForAWeek)
            {
                var paymentForExtra = (totalHoursInAWeek - standardHoursForAWeek) * extraPayment;
                var paymentForStandard = standardHoursForAWeek * standardPayment;
                var totalPayment = paymentForExtra + paymentForStandard;
                return totalPayment;
            }
            else
            {
                return standardPayment * totalHoursInAWeek;
            }
        }

        public double TotalHoursInAWeekForCompany(List<TimeSheetEntry> timeSheetEntries, string companyName)
        {
            return timeSheetEntries
                 .Where(timeSheet => timeSheet.WorkDone.ToLower().Contains(companyName.ToLower()))
                 .Sum(x => x.HoursWorked);
        }
    }
}
