using BookStoreApp.Blazor.WebAssembly.UI.Services.Base;

namespace BookStoreApp.Blazor.WebAssembly.UI.Services
{
    public interface IBookService
    {
        Task<Response<List<BookReadOnlyDTO>>> Get();
        Task<Response<BookDetailsDTO>> Get(int id);
        Task<Response<BookUpdateDTO>> GetForUpdate(int id);
        Task<Response<int>> Create(BookCreateDTO author);
        Task<Response<int>> Edit(int id, BookUpdateDTO author);
        Task<Response<int>> Delete(int id);
    }
}