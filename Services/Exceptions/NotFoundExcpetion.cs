using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundExcpetion : ApplicationException
    {
        public NotFoundExcpetion(string message) : base(message)
        {
        }
    }
}
