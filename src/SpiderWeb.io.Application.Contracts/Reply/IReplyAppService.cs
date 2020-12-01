using SpiderWeb.io.Application;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SpiderWeb.io.Contracts
{

    public interface IReplyAppService :
                ICrudAppService< //Defines CRUD methods
            ReplyDto, //Used to show pages
            Guid, //Primary key of the pages entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateReplyDto> //Used to create/update a pages
    {

    }
}
