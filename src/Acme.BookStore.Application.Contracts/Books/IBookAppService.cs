using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Books
{
    public interface IBookAppService : ICrudAppService<BookDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBookDto>
    {
        /*
        ICrudAppService => Defines CRUD methods for the Book entity.
        BookDto => Data transfer object for show Books.
        Guid => Primary key type of the Book entity.
        PagedAndSortedResultRequestDto => Used for paging and sorting requests.
        CreateUpdateBookDto => Used to create or update a Book entity.
        */
    }
}
