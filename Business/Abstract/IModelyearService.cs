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
        void Add(ModelYear modelYear);
        void Update(ModelYear modelYear);
        void Delete(ModelYear modelYear);

        List<ModelYear> GetAll();
        
    }
}
