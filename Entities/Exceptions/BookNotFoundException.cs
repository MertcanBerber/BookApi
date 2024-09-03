namespace Entities.Exceptions
{
    public abstract partial class NotFoundException
    {
        public sealed class BookNotFoundException : NotFoundException
        {
            public BookNotFoundException(int id) : base($"The Book With id:{id} could not be found")
            {

            }
        }
    }
}