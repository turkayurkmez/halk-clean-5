namespace Functions
{

    public class PrintOption
    {
        public int PageWidth { get; set; }
        public int PageHeight { get; set; }
        public int FontWidth { get; set; }
        public bool IsColorful { get; set; }
    }
    public class Report
    {
        public Report(string filePath)
        {
            try
            {
                validateFile(filePath);
            }
            catch (InvalidExcelFileException ex)
            {
                //ex.Reason = "Report nesnesi oluşturulamadı";

                throw ex;
            }
        }

        bool isFileExists(string path)
        {
            return File.Exists(path);
        }

        bool isFormatAvailable(string path)
        {
            return Convert.ToBoolean(new Random().Next(2));
        }

        bool isValid(string path)
        {
            return isFileExists(path) && isFormatAvailable(path);
        }

        void validateFile(string path)
        {
            if (!isValid(path))
            {
                throw new InvalidExcelFileException("Excel Dosyası yok veya yanlış formatta ") { Reason = "Report nesnesi oluşturulamadı" };
            }
        }

        public void Print(PrintOption option)
        {

        }
    }
}
