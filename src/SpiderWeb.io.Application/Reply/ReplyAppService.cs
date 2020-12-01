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

    public class ReplyAppService :
       CrudAppService<
           Reply, //The Source entity
           ReplyDto, //Used to show books
           Guid, //Primary key of the source entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateReplyDto>, //Used to create/update a book
       IReplyAppService //implement the IBookAppService
    {
        public ReplyAppService(IRepository<Reply, Guid> repository)
            : base(repository)
        {

        }
    }
}
