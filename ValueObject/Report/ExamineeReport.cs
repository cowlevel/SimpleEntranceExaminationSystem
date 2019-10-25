using System;

namespace ValueObject.Report
{
    public class ExamineeReport
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string City { get; set; }
        public DateTime? DateTimeRegisteredOrAdded { get; set; }
    }
}