using Core.DataAccess;
using Entities.Concrete;
using Entities.Dto;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public  interface ICarDal : IEntityRepository<Car>
    {   
        List<CarDetailsDto> GetCarDetails();
        
     
    }
}
