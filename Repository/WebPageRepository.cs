using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebASPNETCore.Models;
using WebASPNETCore.Services;

namespace WebASPNETCore.Repository
{
    public class WebPageRepository:IWebPage
    {
        private DBContext db;
        public WebPageRepository(DBContext _db)
        {
            db = _db;
        }

        public IEnumerable<WebPage> GetWebPagesAll => db.WebPage;

        public void Add(WebPage _WebPage)
        {
            db.WebPage.Add(_WebPage);
            db.SaveChanges();
        }

        public WebPage GetWebPageByID(int? Id)
        {
            WebPage dbEntity = db.WebPage.Find(Id);
            return dbEntity;
        }

        public void Remove(int? Id)
        {
            WebPage dbEntity = db.WebPage.Find(Id);
            db.WebPage.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
