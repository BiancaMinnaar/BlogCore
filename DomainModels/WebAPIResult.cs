using System;
namespace DomainModels
{
    public class WebAPIResult<T>
    {
        public T DataModel { get; set; }
        public ServiceFeedback Status { get; set; }
    }
}
