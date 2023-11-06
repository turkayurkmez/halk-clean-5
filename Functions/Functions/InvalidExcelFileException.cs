namespace Functions
{


    [Serializable]
    public class InvalidExcelFileException : Exception
    {
        public string Reason { get; set; }
        public string SourceOfException { get; set; }
        public InvalidExcelFileException()
        {


        }
        public InvalidExcelFileException(string message) : base(message) { }
        public InvalidExcelFileException(string message, Exception inner) : base(message, inner) { }
        protected InvalidExcelFileException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public override string Message
        {
            get { return base.Message + " " + Reason; }
        }
    }
}
