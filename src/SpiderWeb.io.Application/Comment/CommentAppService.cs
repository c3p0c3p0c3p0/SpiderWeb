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

    public class CommentAppService :
       CrudAppService<
           Comment, //The Source entity
           CommentDto, //Used to show books
           Guid, //Primary key of the source entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateCommentDto>, //Used to create/update a book
       ICommentAppService //implement the IBookAppService
    {
        public CommentAppService(IRepository<Comment, Guid> repository)
            : base(repository)
        {

        }
    }
}
