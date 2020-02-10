using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR400_lab2_max_jern
{
    class FetchDBData
    {
        //Method to get name of Care Center through ID
        public string GetCareCenter(int id)
        {
            using (CareGivingDBEntities db = new CareGivingDBEntities())
            {
                //Finds row matching the given id and returns name from that row
                var rowData = db.CareCenter.Find(id);
                string careName = rowData.Name;
                return careName;
            }
        }
        //Method to get name of Care Giver through ID
        public string GetCareGiver(int id)
        {
            using (CareGivingDBEntities db = new CareGivingDBEntities())
            {
                //Finds row matching the given id and returns first and last name from that row
                var rowData = db.CareGiver.Find(id);
                string careName = rowData.FirstName + " " + rowData.LastName;
                return careName;
            }
        }
    }
}
