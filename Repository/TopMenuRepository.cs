using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebASPNETCore.Models;
using WebASPNETCore.Services;

namespace WebASPNETCore.Repository
{
    public class TopMenuRepository:ITopMenu
    {
        private DBContext db;
        public TopMenuRepository(DBContext _db)
        {
            db = _db;
        }
        public IEnumerable<TopMenu> GetTopMenusAll => db.TopMenu;

        public void Add(TopMenu _TopMenu)
        {
            db.TopMenu.Add(_TopMenu);
            db.SaveChanges();
        }

        public TopMenu GetTopMenuByID(int? Id)
        {
            TopMenu dbEntity = db.TopMenu.Find(Id);
            return dbEntity;
        }

        public void Remove(int? Id)
        {
            TopMenu dbEntity = db.TopMenu.Find(Id);
            db.TopMenu.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
