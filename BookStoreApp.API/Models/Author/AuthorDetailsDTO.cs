using BookStoreApp.API.Models.Book;

namespace BookStoreApp.API.Models.Author
{
    public class AuthorDetailsDTO : AuthorReadOnlyDTO
    {
        public List<BookReadOnlyDTO> Books { get; set; }
    }
}
