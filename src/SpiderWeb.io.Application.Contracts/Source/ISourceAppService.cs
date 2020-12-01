using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SpiderWeb.io.Sources
{
    public interface ISourceAppService :
                ICrudAppService< //Defines CRUD methods
            SourceDto, //Used to show sources
            Guid, //Primary key of the sources entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateSourceDto> //Used to create/update a sources
    {
        
    }
}
