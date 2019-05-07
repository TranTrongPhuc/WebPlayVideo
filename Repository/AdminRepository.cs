using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebASPNETCore.Models;
using WebASPNETCore.Services;

namespace WebASPNETCore.Repository
{
    public class AdminRepository : IAdmin
    {
        private DBContext db;
        public AdminRepository(DBContext _db)
        {
            db = _db;
        }
        public IEnumerable<Admin> GetAdminsAll => db.AdminLogin;

        public void Add(Admin _Admin)
        {
            db.AdminLogin.Add(_Admin);
            db.SaveChanges();
        }

        public Admin GetAdminByID(int? Id)
        {
            Admin dbEntity = db.AdminLogin.Find(Id);
            return dbEntity;
        }

        public void Remove(int? Id)
        {
            Admin dbEntity = db.AdminLogin.Find(Id);
            db.AdminLogin.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
