using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebASPNETCore.Models;
using WebASPNETCore.Services;

namespace WebASPNETCore.Repository
{
    public class PostForPageRepository : IPostForPage
    {
        private DBContext db;
        public PostForPageRepository(DBContext _db)
        {
            db = _db;
        }
        public IEnumerable<PostForPage> GetPostForPagesAll => db.PostForPage;

        public void Add(PostForPage _PostForPage)
        {
            db.PostForPage.Add(_PostForPage);
            db.SaveChanges();
        }
        public PostForPage PostForPagByID(int? Id)
        {
            PostForPage dbEntity = db.PostForPage.Find(Id);
            return dbEntity;
        }
        public void Remove(int? Id)
        {
            PostForPage dbEntity = db.PostForPage.Find(Id);
            db.PostForPage.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
