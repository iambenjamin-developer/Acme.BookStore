using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
{
    public class BookAppService : CrudAppService<Book, BookDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBookDto>, IBookAppService
    {
        /*
        CrudAppService => Defines CRUD methods for the Book entity.
        Book => Domain entity representing a Book.
        BookDto => Data transfer object for show Books.
        Guid => Primary key type of the Book entity.
        PagedAndSortedResultRequestDto => Used for paging and sorting requests.
        CreateUpdateBookDto => Used to create or update a Book entity.
        IBookAppService => Implement the IBookAppService
        */
        public BookAppService(IRepository<Book, Guid> repository)
            : base(repository)
        {

        }
    }
}
