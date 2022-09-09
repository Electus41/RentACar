using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ModelYearManager : IModelyearService
    {
        IModelYearDal _modelYearDal;

        public ModelYearManager (IModelYearDal modelYearDal)
        {
            _modelYearDal = modelYearDal;
        }       
            

        public void Add(ModelYear modelYear)
        {
            if (modelYear.ModelYearName>2015)
            {
                _modelYearDal.Add(modelYear);
            }
            else
            {
                Console.WriteLine("Düşük Model");
            }
        }

        public void Delete(ModelYear modelYear)
        {
            _modelYearDal.Delete(modelYear);
        }

        

        public List<ModelYear> GetAll()
        {
            var result = _modelYearDal.GetAll();
            return result;
        }

        public void Update(ModelYear modelYear)
        {
            _modelYearDal.Update(modelYear);
        }
    }
}
