using SpiderWeb.io.Domain;
using SpiderWeb.io.DomainShared;
using SpiderWeb.io.Sources;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SpiderWeb.io.Application
{
    public class SourceAppService :
        CrudAppService<
            Source, //The Source entity
            SourceDto, //Used to show books
            Guid, //Primary key of the source entity
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
