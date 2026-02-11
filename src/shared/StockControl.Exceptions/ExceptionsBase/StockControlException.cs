using System.Net;

namespace StockControl.Exceptions.ExceptionsBase
{
    public abstract class StockControlException : SystemException
    {
        public StockControlException(string message) : base(message) { }

        public abstract IList<string> GetErrorMessages();
        public abstract HttpStatusCode GetStatusCode();
    }
}
