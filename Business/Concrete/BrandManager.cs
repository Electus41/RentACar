using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager (IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length>2)
            {

                _brandDal.Add(brand);
                Console.WriteLine("EKLENDİ");
            }
            else
            {
                Console.WriteLine("Marka Bulunamadı");
            }

        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetCarsByBrandId(int Id)
        {
            return _brandDal.GetAll(b=>b.Id == Id);
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);


        }
    }
}
