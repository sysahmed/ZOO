using System.Collections.Generic;
using ZOO.Core.Entities.Results;
using ZOO.Entities.Concrete;

namespace ZOO.Business.Abstract
{
    public interface IAnimalService
    {
        IDataResult<List<BaseAnimal>> GetList();
        IResult Add(BaseAnimal animal);
        IResult Delete(BaseAnimal animal);
        IResult Update(BaseAnimal animal);
    }
}
