using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR400_lab2_max_jern
{
    class ShowDBData
    {
        FetchDBData fetchData = new FetchDBData();
        //Method to print all Care Givers
        public void ShowCareGiver()
        {
            using (CareGivingDBEntities db = new CareGivingDBEntities())
            {
                //Creates a list of Care Givers from the database
                var careGiverList = db.CareGiver.ToList();
                //Loops through the database tables and prints all relevant info
                foreach (var item in careGiverList)
                {
                    Console.WriteLine("Last Name: " + item.LastName + " First Name: " + item.FirstName + " Role: " + item.Role + " Workplace: " + fetchData.GetCareCenter(item.CareCenterId));
                }
            }
        }
        //Method to print all Care Takers
        public void ShowCareTaker()
        {
            using (CareGivingDBEntities db = new CareGivingDBEntities())
            {
                //Creates a list of Care Takers from the database
                var careTakerList = db.CareTaker.ToList();
                //Loops through the database tables and prints all relevant info
                foreach (var item in careTakerList)
                {
                    Console.WriteLine("Last Name: " + item.LastName + " First Name: " + item.FirstName +  "Liaison: " + fetchData.GetCareGiver(item.CareGiverId));
                }
            }
        }
    }
}
