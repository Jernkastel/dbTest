using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR400_lab2_max_jern
{
    class AddData
    {
        string fname;
        string lname;
        string role;
        int workplaceID;
        int liaisonID;

        public void AddCareGiver()
        {
            using (CareGivingDBEntities db = new CareGivingDBEntities())
            {
                Console.WriteLine("Please enter the last name of the new Care Giver below:");
                try
                {
                    lname = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong");
                    throw;
                }
                Console.WriteLine("Please enter the first name of the new Care Giver below:");
                try
                {
                    fname = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong");
                    throw;
                }
                Console.WriteLine("Please enter the role of the new Care Giver below (Orderly, Nurse etc.):");
                try
                {
                    role = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong");
                    throw;
                }
                Console.WriteLine("Please enter the unique ID of the workplace of the new Care Giver below:");
                try
                {
                    workplaceID = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong");
                    throw;
                }

                CareGiver newCareGiver = new CareGiver();
                newCareGiver.FirstName = fname;
                newCareGiver.LastName = lname;
                newCareGiver.Role = role;
                newCareGiver.CareCenterId = workplaceID;

                db.CareGiver.Add(newCareGiver);
                db.SaveChanges();
            }
        }

        public void AddCareTaker()
        {
            using (CareGivingDBEntities db = new CareGivingDBEntities())
            {
                Console.WriteLine("Please enter the last name of the new Care Taker below:");
                try
                {
                    lname = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong");
                    throw;
                }
                Console.WriteLine("Please enter the first name of the new Care Taker below:");
                try
                {
                    fname = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong");
                    throw;
                }
                Console.WriteLine("Please enter the unique ID of the liaison for the new Care Taker below:");
                try
                {
                    liaisonID = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong");
                    throw;
                }

                CareTaker newCareTaker = new CareTaker();
                newCareTaker.FirstName = fname;
                newCareTaker.LastName = lname;
                newCareTaker.CareGiverId = liaisonID;

                db.CareTaker.Add(newCareTaker);
                db.SaveChanges();
            }
        }
    }
}
