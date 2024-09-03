namespace Entities.Exceptions
{
    public abstract partial class NotFoundException
    {

        public abstract partial class NotFound : Exception
        {

            protected NotFound(string message) : base(message)
            {

            }
        }

        public sealed class BookNotFound : NotFound
        {
            public BookNotFound(int id) : base($"The Book With id:{id} could not be found")
            {

            }
        }
    }

   
}