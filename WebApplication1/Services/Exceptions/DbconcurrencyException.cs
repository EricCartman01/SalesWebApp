using System;


namespace WebApplication1.Services.Exceptions
{
    public class DbconcurrencyException : ApplicationException
    {
        public DbconcurrencyException(string message) : base(message)
        {

        }
    }
}
