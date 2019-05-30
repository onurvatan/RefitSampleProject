using Refit;
using RefitSampleProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RefitSampleProject.Services
{
    public interface IPostService
    {
        [Get("/posts")]
        Task<List<Post>> GetPosts();
    }
}
