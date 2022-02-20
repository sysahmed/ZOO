using System.Collections.Generic;
using System.Linq;
using ZOO.Business.Abstract;
using ZOO.Business.Constants;
using ZOO.Core.Entities.Results;
using ZOO.DataAccess.Abstract;
using ZOO.Entities.Concrete;

namespace ZOO.Business.Concrete
{
    public class AnimalManager : IAnimalService
    {
        IAnimalDal _animalDal;
        public AnimalManager(IAnimalDal animalDal)
        {
            _animalDal = animalDal;
        }
        public IResult Add(BaseAnimal animal)
        {
            _animalDal.Add(animal);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(BaseAnimal animal)
        {
            _animalDal.Delete(animal);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<BaseAnimal>> GetList()
        {
            return new SuccessDataResult<List<BaseAnimal>>(_animalDal.GetList().ToList());
        }

        public IResult Update(BaseAnimal animal)
        {
            _animalDal.Update(animal);
            return new SuccessResult(Messages.Updated);
        }
    }
}
