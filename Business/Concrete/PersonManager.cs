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
    public class PersonManager : IPersonService
    {
        IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public List<Person> GetAllPerson()
        {
            return _personDal.GetAll();
        }

        public Person GetPersonAdded(Person person)
        {
            _personDal.AddedEntity(person);
            return person;
        }

        //public Person GetPersonAdded(Person person)
        //{
        //     _personDal.AddedEntity(person);
        //}
    }
}
