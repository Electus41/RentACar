using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
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

        [ValidationAspect(typeof(ModelYearValidator))]
        public IResult Add(ModelYear modelYear)
        {
            if (modelYear.ModelYearName>2015)
            {
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult();
            }
        }

        public IResult Delete(ModelYear modelYear)
        {
            _modelYearDal.Delete(modelYear);
            return new SuccessResult();
        }

        

        public IDataResult<List<ModelYear>> GetAll()
        {
            return new SuccessDataResult<List<ModelYear>>(_modelYearDal.GetAll());
        }

        public IResult Update(ModelYear modelYear)
        {
            _modelYearDal.Update(modelYear);
            return new SuccessResult();
        }
    }
}
