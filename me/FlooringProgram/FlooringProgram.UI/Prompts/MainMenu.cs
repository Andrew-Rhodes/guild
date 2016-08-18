using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.UI.WorkFlow;

namespace FlooringProgram.UI.Prompts
{
    public class MainMenu
    {
        public void MainMenuDisplay()
        {
            //try
            //{
                string choice = "";
                do
                {
                    Console.Clear();
                    Console.WriteLine("\t Flooring Program");
                    Console.WriteLine();
                    Console.WriteLine(DateTime.Now);
                    Console.WriteLine();
                    Console.WriteLine("1.) Display Orders");
                    Console.WriteLine();
                    Console.WriteLine("2.) Add an Order");
                    Console.WriteLine();
                    Console.WriteLine("3.) Edit an Order");
                    Console.WriteLine();
                    Console.WriteLine("4.) Remove an Order");
                    Console.WriteLine();
                    Console.WriteLine("5.) Quit");
                    Console.WriteLine();
                    Console.WriteLine("Select 1 - 5 to begin that operation.");

                    choice = Console.ReadLine();

                    if (choice != "5")
                    {
                        OperationSelection(choice);
                    }

                } while (choice != "5");
            }
            //catch (Exception ex)
            //{
            //    LogError(ex);
            //}
      //  }

        public void LogError(Exception ex)
        {
            Console.WriteLine();
            Console.WriteLine("!!!!!PROGRAM ERROR!!!!!");

            string message = "-----------------------------------------------------------";
            message += Environment.NewLine;
            message += string.Format("Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"));

            message += Environment.NewLine;
            message += string.Format("Message: {0}", ex.Message);

            message += Environment.NewLine;
            message += string.Format("Source: {0}", ex.Source);

            message += Environment.NewLine;
            message += string.Format("TargetSite: {0}", ex.TargetSite.ToString());

            message += Environment.NewLine;
            message += "-----------------------------------------------------------";

            message += Environment.NewLine;
            string FILENAME = @"DataFiles\Log.txt";
            using (StreamWriter writer = new StreamWriter(FILENAME, true))
            {
                writer.WriteLine(message);
                writer.Close();
            }

            Console.ReadLine();
        }


        public void OperationSelection(string choice)
        {
            switch (choice)
            {
                case "1":
                    DisplayOrderWorkFlow searchOrder = new DisplayOrderWorkFlow();
                    searchOrder.Execute();
                    break;
                case "2":
                    AddWorkFlow addOrderWorkFlow = new AddWorkFlow();
                    addOrderWorkFlow.Execute();
                    break;
                case "3":
                    EditOrderWorkFlow editOrder = new EditOrderWorkFlow();
                    editOrder.Execute();
                    break;
                case "4":
                    RemoveOrderWorkFlow removeOrder = new RemoveOrderWorkFlow();
                    removeOrder.Execute();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("{0} is not a valid choice.", choice);
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}

