namespace AceApp.Data
{
    public class EmailSettings
    {
        /// <summary>
        /// Primary Domain
        /// </summary>
        public String PrimaryDomain { get; set; }

        /// <summary>
        /// Primary Port Number
        /// </summary>
        public int PrimaryPort { get; set; }

        /// <summary>
        /// User Email Address
        /// </summary>
        public string UsernameEmail { get; set; }

        /// <summary>
        /// User Password
        /// </summary>
        public string UsernamePassword { get; set; }

        /// <summary>
        /// Sender Email Address
        /// </summary>
        public string FromEmail { get; set; }

        /// <summary>
        /// Receiver Email Address
        /// </summary>
        public string ToEmail { get; set; }

        /// <summary>
        /// Email Address in cc
        /// </summary>
        public string CcEmail { get; set; }
    }
}
