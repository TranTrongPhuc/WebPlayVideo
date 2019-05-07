using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebASPNETCore.Models;

namespace WebASPNETCore.Services
{
    public interface IPostForPage
    {
        IEnumerable<PostForPage> GetPostForPagesAll { get; }
        PostForPage PostForPagByID(int? Id);
        void Add(PostForPage _PostForPage);
        void Remove(int? Id);
    }
}
