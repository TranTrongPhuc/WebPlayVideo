using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebASPNETCore.Models;

namespace WebASPNETCore.Services
{
   public interface IWebPage
    {
        IEnumerable<WebPage> GetWebPagesAll { get; }
        WebPage GetWebPageByID(int? Id);
        void Add(WebPage _WebPage);
        void Remove(int? Id);
    }
}
