using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SpiderWeb.io.Sources
{
    public interface ISourceAppService :
                ICrudAppService< //Defines CRUD methods
            SourceDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateSourceDto> //Used to create/update a book
    {

    }
}
