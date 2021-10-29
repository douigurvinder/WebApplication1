using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Client.http;
using WebApplication1.Shared;

namespace WebApplication1.Client.Genre
{
    public class GenreRepostosyTow : IGenreRepostosyTow
    {
        private string url = "api/genres2";
        private readonly IHttpService httpService;
        public GenreRepostosyTow(IHttpService httpService)
        {
            this.httpService = httpService;

        }
        public async Task CreateGenre2(Class2 class2)
        {
            var response = await httpService.Post(url, class2);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

        }
    }
}
