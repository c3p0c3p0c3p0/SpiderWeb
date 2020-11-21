using SpiderWeb.io.Sources;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace SpiderWeb.io
{
    public class SpiderWebDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Source, Guid> _sourceRepository;

        public SpiderWebDataSeederContributor(IRepository<Source, Guid> sourceRepository)
        {
            _sourceRepository = sourceRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _sourceRepository.GetCountAsync() <= 0)
            {
                await _sourceRepository.InsertAsync(
                    new Source
                    {
                        Name = "Banned.Video",
                        URL = "https://banned.video/",
                        ContentType = ContentType.Video,
                        SourceType = SourceType.AlternativeMedia,
                        Tags = "Banned Video, Video, Banned, #BannedVideo"
                    },
                    autoSave: true
                );

                await _sourceRepository.InsertAsync(
                    new Source
                    {
                        Name = "Breitbart",
                        URL = "https://www.breitbart.com/",
                        ContentType = ContentType.Article,
                        SourceType = SourceType.AlternativeMedia,
                        Tags = "Breitbart, Breitbart News, BreitbartNews, #Breitbart, @Breitbart"
                    },
                    autoSave: true
                );
            }
        }
    }
}
