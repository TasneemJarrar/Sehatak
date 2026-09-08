

namespace Sehatak.Application.DTOs.Exceptions
{
    public class BusinessException : Exception
    {
        public BusinessException(string key) : base(key) { }
    }
}
