using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfEF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void DeletePerson(int id)
        {
            PersonContext po = new PersonContext();
            var c = (from per in po.Persons
                     where per.Id == id
                     select per).First();

            po.Persons.Remove(c);
            po.SaveChanges();
                     
        }

        public IEnumerable<Person> GetPerson()
        {
            List<Person> li = new List<Person>();
            PersonContext po = new PersonContext();
            return li;
        }

        public void InsertPerson(Person pobj)
        {
            PersonContext po = new PersonContext();
            po.Persons.Add(pobj);
            po.SaveChanges();
        }

        public void UpdatePerson(Person pobj)
        {
            PersonContext po = new PersonContext();
            var c = (from per in po.Persons
                     where per.Id == pobj.Id
                     select per).First();

            c.Name = pobj.Name;
            c.Address = pobj.Address;
            po.SaveChanges();
        }
    }
}
