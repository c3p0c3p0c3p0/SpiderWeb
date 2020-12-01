using AutoMapper;
using SpiderWeb.io.Application;
using SpiderWeb.io.Contracts;
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

            CreateMap<Page, PageDto>();
            CreateMap<CreateUpdatePageDto, Page>();

            CreateMap<Comment, CommentDto>();
            CreateMap<CreateUpdateCommentDto, Comment>();

            CreateMap<Reply, ReplyDto>();
            CreateMap<CreateUpdateReplyDto, Reply>();
        }
    }
}
