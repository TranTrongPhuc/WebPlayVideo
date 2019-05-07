using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebASPNETCore.Models;

namespace WebASPNETCore.Services
{
   public interface ITopMenu
    {
        IEnumerable<TopMenu> GetTopMenusAll { get; }
        TopMenu GetTopMenuByID(int? Id);
        void Add(TopMenu _TopMenu);
        void Remove(int? Id);
    }
}
