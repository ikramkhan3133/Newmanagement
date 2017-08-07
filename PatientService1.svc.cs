using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FirstProjectWcfService6
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class PatientService1 : IPatientService1
    {

        public List<patient> Getallpatient()
        {
            using (var db = new WcfServiceDataBaseEntities())
            {
                return db.patients.ToList();
            }

        }


        public patient GetPatient(string id)
        {
            Int32 Id = Convert.ToInt32(id);
            using(var db = new WcfServiceDataBaseEntities())
            {
                return db.patients.FirstOrDefault(p => p.Id == p.Id);
            }

        }
    }
}