using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Shared;

namespace WebApplication1.Client.Genre
{
    public interface IGenreRepostory
    {
        Task CreateGenre(Class1 genre);
    }
}
