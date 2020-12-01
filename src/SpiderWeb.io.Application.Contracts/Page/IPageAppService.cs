using SpiderWeb.io.Application;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SpiderWeb.io.Contracts
{

    public interface IPageAppService :
                ICrudAppService< //Defines CRUD methods
            PageDto, //Used to show pages
            Guid, //Primary key of the pages entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdatePageDto> //Used to create/update a pages
    {

    }
}
