using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfEF
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IEnumerable<Person> GetPerson();

        [OperationContract]
        void InsertPerson(Person pobj);

        [OperationContract]
        void UpdatePerson(Person pobj);

        [OperationContract]
        void DeletePerson(int id);
    }
}
