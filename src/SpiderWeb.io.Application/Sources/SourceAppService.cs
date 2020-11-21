using SpiderWeb.io.Sources;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
{
    public class SourceAppService :
        CrudAppService<
            Source, //The Book entity
            SourceDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateSourceDto>, //Used to create/update a book
        ISourceAppService //implement the IBookAppService
    {
        public SourceAppService(IRepository<Source, Guid> repository)
            : base(repository)
        {

        }
    }
}
