using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ZOO.DataAccess.Abstract;
using ZOO.Entities.Concrete;

namespace ZOO.DataAccess.Concrete.InMemory
{

    public class InMemoryAnimalDal : IAnimalDal
    {
        List<BaseAnimal> _animalList;
        BaseAnimal _animal;
        public InMemoryAnimalDal()
        {
            _animal = new BaseAnimal();
            _animalList = new List<BaseAnimal>();
        }
        
        public void Add(BaseAnimal entity)
        {
            if(_animalList.Count<=15)
            { _animalList.Add(entity); }
        }

        public void Delete(BaseAnimal entity)
        {
            BaseAnimal animal = _animalList.FirstOrDefault(a => a.AnimalId == entity.AnimalId&&a.AnimalName==entity.AnimalName);
            _animalList.Remove(animal);
        }

        public IList<BaseAnimal> GetList(Expression<Func<BaseAnimal, bool>> filter = null)
        {
            return _animalList;
        }

        public void Update(BaseAnimal entity)
        {
           _animal=_animalList.FirstOrDefault(a=>a.AnimalId==entity.AnimalId&&a.AnimalName==entity.AnimalName);
            _animal.AnimalHealtPoints=entity.AnimalHealtPoints;
            _animal.life = entity.life;
           
            switch (_animal.AnimalName)
            { case "Lions":
                    if (_animal.AnimalHealtPoints < 50)
                    {
                        Delete(_animal);
                    }else if (_animal.AnimalHealtPoints >= 200)
                    {
                        Add(new Lions{AnimalName="Lions",AnimalHealtPoints=100,AnimalId= _animalList.Count + 1});
                    }
                        break;
                case "Monkeys":
                    if (_animal.AnimalHealtPoints < 40)
                    {
                        Delete(_animal);
                    }
                    else if (_animal.AnimalHealtPoints >= 200)
                    {
                        Add(new Monkeys { AnimalName = "Monkeys", AnimalHealtPoints = 100, AnimalId = _animalList.Count + 1 });
                    }
                    break;
                case "Elephants":
                    if (_animal.AnimalHealtPoints < 70)
                    {
                        Delete(_animal);
                    }
                    else if (_animal.AnimalHealtPoints >= 200)
                    {
                        Add(new Elephants { AnimalName = "Elephants", AnimalHealtPoints = 100, AnimalId = _animalList.Count + 1 });
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
