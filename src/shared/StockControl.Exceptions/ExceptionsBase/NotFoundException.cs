using System.Net;

namespace StockControl.Exceptions.ExceptionsBase
{
    public class NotFoundException : StockControlException
    {
        public NotFoundException(string message) : base(message)
        {
        }

        public override IList<string> GetErrorMessages() => [Message];

        public override HttpStatusCode GetStatusCode() => HttpStatusCode.NotFound;
    }
}
