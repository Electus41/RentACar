using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IModelyearService
    {
        IResult Add(ModelYear modelYear);
        IResult Update(ModelYear modelYear);
        IResult Delete(ModelYear modelYear);

        IDataResult<List<ModelYear>> GetAll();
        
    }
}
