using System;

class Program
{

    static void Main(string[] args)
    {
    //   Making a new instance of journal
        Journal journal01 = new Journal();

        int response = 0;
        while (response != 5) {

            Console.WriteLine("please select an option for your journal \n 1. write in your journal \n 2. Display current journal \n 3. Save your Enteries \n 4. Load a previous jounal \n 5. Quit.");
    
            response = int.Parse(Console.ReadLine());

            if (response == 1) {
                journal01.Write();
            }
            else if (response ==2) {
                journal01.Display();
                
            }
            else if (response ==3) {
                journal01.Save();
            }
            else if (response ==4) {
                journal01.Load();
            }
            else if (response ==5) {
                break;
            }
        }



    }
}