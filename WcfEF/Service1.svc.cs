﻿using System;
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
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPerson()
        {
            throw new NotImplementedException();
        }

        public void InsertPerson(Person pobj)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(Person pobj)
        {
            throw new NotImplementedException();
        }
    }
}
