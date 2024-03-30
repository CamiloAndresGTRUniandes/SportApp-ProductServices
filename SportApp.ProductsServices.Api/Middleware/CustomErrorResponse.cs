namespace SportApp.ProductsServices.Api.Middleware ;

    /// <summary>
    /// Custom response class
    /// </summary>
    public class CustomErrorResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        public CustomErrorResponse(int code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary>
        /// Internal code
        /// </summary>
        public int Code { get; }

        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; }
    }
