namespace summary.Data.Services
{
    public class bookService : IBookService
    {
        public void AddBook(Book newBook)
        {
            Data.Books.Add(newBook);
        }

        public void DeleteBook(int id)
        {
            var book = Data.Books.FirstOrDefault(b => b.Id == id);
            Data.Books.Remove(book);
        }

        public List<Book> GetAllBooks()
        {
            return Data.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return Data.Books.FirstOrDefault(b => b.Id == id);
        }

        public void UpdateBook(int id, Book newBook)
        {
            var oldBook = Data.Books.FirstOrDefault(b => b.Id == id);
            if (oldBook != null)
            {
                oldBook.Title= newBook.Title;
                oldBook.Description= newBook.Description;
                oldBook.Author= newBook.Author;
                oldBook.Rate= newBook.Rate;
                oldBook.DateStart= newBook.DateStart;
                oldBook.DateRead= newBook.DateRead;
            }
        }
    }
}
