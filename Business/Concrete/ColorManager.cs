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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager (IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);   
            
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
                
        }

        public List<Color> GetCarsByColorId(int Id)
        {
            var colors = _colorDal.GetAll();
            return colors;
        }

        public void Update(Color color)
        {
            
          _colorDal.Update(color);
        }
    }
}
