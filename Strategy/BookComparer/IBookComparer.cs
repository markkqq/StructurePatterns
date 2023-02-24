namespace Strategy
{
    public interface IBookComparer
    {
        public int Compare(Book firstBook, Book secondBook);
    }
}