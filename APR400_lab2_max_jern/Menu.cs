using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR400_lab2_max_jern
{
    class Menu
    {
        ShowDBData showData = new ShowDBData();
        AddData addData = new AddData();
        public Menu()
        {
            //Switch case menu with initial value -1 as the menu exits on 0
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("Welcome to CareCenter console!");
                Console.WriteLine("1. Print Care Giver Data");
                Console.WriteLine("2. Print Care Taker Data");
                Console.WriteLine("3. Add Care Giver");
                Console.WriteLine("4. Add Care Taker");
                Console.WriteLine("0. Exit Program");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            //Runs the ShowCareGiver method to print all information stored about the Care Giver
                            showData.ShowCareGiver();
                            Console.WriteLine("Press any key to return to the menu.");
                            break;
                        case 2:
                            //Runs the ShowCareTaker method to print all information stored about the Care Taker
                            showData.ShowCareTaker();
                            Console.WriteLine("Do you wish to add");
                            break;
                        case 3:
                            //Runs the AddCareGiver method to add a bew entity into the database
                            addData.AddCareGiver();
                            break;
                        case 4:
                            //Runs the AddCareTaker method to add a bew entity into the database
                            addData.AddCareTaker();
                            break;
                        case 0:
                            //Console is exiting - press any key to exit the console from here
                            Console.WriteLine("Console is exiting...");
                            break;
                    }
                }
                //simple catch
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter either number from '0' to '4' to make your choice.");
                    Console.WriteLine("Press any key to return to the menu.");
                }
                //Clears the console window whenever a line is read to reduce clutter
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
