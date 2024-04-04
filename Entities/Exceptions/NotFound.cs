
namespace Entities.Exceptions
{
    public abstract partial class NotFoundException : Exception
    {

        protected NotFoundException(string message) : base(message)
        {

        }
    }

    public abstract partial class NotFound : Exception
    {

        protected NotFound(string message) : base(message)
        {

        }
    }
}