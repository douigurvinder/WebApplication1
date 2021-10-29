using System;
using System.Threading.Tasks;
using WebApplication1.Client.http;
using WebApplication1.Shared;

namespace WebApplication1.Client.Genre
{
    public class GenreRepostory : IGenreRepostory
    {
        private readonly IHttpService httpService;
        private string url = "api/genres";
        public GenreRepostory(IHttpService httpService)
        {
            this.httpService = httpService;

        }
        public async Task CreateGenre(Class1 genre)
        {
            var response = await httpService.Post(url,genre);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}

