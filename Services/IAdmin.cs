using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebASPNETCore.Models;

namespace WebASPNETCore.Services
{
    public interface IAdmin
    {
        IEnumerable<Admin> GetAdminsAll { get; }
        Admin GetAdminByID(int? Id);
        void Add(Admin _Admin);
        void Remove(int? Id);
    }
}
