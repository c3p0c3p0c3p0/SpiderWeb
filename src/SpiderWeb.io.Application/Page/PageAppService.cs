using SpiderWeb.io.Contracts;
using SpiderWeb.io.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SpiderWeb.io.Application
{

    public class PageAppService :
       CrudAppService<
           Page, //The Source entity
           PageDto, //Used to show books
           Guid, //Primary key of the source entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdatePageDto>, //Used to create/update a book
       IPageAppService //implement the IBookAppService
    {
        public PageAppService(IRepository<Page, Guid> repository)
            : base(repository)
        {

        }
    }
}
