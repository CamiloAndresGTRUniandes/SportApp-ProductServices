namespace SportApp.ProductsServices.Api.Middleware ;

    /// <summary>
    /// Logging events
    /// </summary>
    public static class LoggingEvents
    {
        /// <summary>
        /// Bad Request
        /// </summary>
        public static readonly int BadRequest = 400;

        /// <summary>
        /// Data too long DbException
        /// </summary>
        public static readonly int DataTooLongException = 996;

        /// <summary>
        /// Unknown Event
        /// </summary>
        public static readonly int Unknown = 999;

        /// <summary>
        /// Represents the exception when the name exceeds the maximum length.
        /// </summary>
        public static readonly int NameMaxLengthException = 1000;

        /// <summary>
        /// Represents the exception when the description exceeds the maximum length.
        /// </summary>
        public static readonly int DescriptionMaxLengthException = 1000;

        public static readonly int PlanNotFoundException = 7001;
        public static readonly int CategoryNotFoundException = 8001;

        /// <summary>
        /// Invalid Display Name
        /// </summary>
        public static readonly int InvalidDisplayName = 9000;
    }
