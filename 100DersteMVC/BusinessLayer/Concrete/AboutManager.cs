using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _abotDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _abotDal = aboutDal;
        }

        public void AboutDelete(About about)
        {
            _abotDal.Delete(about);
        }

        public void AboutUpdate(About about)
        {
            _abotDal.Update(about);
        }

        
        

        public About GetByID(int id)
        {
            return _abotDal.Get(x=>x.AboutID==id);
        }

        public List<About> GetList()
        {
            return _abotDal.List();
        }

        public void AboutAdd(About about)
        {
            _abotDal.Insert(about);
        }
    }
}
