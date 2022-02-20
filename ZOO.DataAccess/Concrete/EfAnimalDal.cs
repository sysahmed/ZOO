using ZOO.Core.DataAccess.EntityFramework;
using ZOO.DataAccess.Abstract;
using ZOO.DataAccess.Concrete.EntityFramewor.Context;
using ZOO.Entities.Concrete;

namespace ZOO.DataAccess.Concrete
{
    public class EfAnimalDal : EfEntityRepositoryBase<BaseAnimal, MyDbContext>, IAnimalDal
    {

    }
}
