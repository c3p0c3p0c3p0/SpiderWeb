using AutoMapper;
using SpiderWeb.io.Domain;
using SpiderWeb.io.Sources;

namespace SpiderWeb.io
{
    public class ioApplicationAutoMapperProfile : Profile
    {
        public ioApplicationAutoMapperProfile()
        {
            CreateMap<Source, SourceDto>();
            CreateMap<CreateUpdateSourceDto, Source>();
        }
    }
}
