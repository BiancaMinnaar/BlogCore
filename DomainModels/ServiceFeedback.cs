using System;
namespace DomainModels
{
    public class ServiceFeedback
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
    }
}
