namespace ShekelHomeAsssignment.Models
{
    public class ErrorResponse : Exception
    {
        public int ErrorCode { get; set; }

        public ErrorResponse(int errorCode ,string message):base(message)
        {
            ErrorCode = errorCode;  
        }
    }
}
