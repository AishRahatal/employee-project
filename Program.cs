using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage problem!");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Output of UC1");
            Console.WriteLine("Check employee's attendance:");
            UC1_Empattendance.get_attendance();
            Console.ReadKey();
            Console.WriteLine("****************************************************************");
            
            Console.WriteLine("Output of UC2");
            Console.WriteLine("Get wage of employee fulltime :");
            UC2_Empwage.get_wage();
            Console.ReadKey();
            Console.WriteLine("***************************************************************");

            Console.WriteLine("Output of UC3");
            Console.WriteLine("Get wage of employee fulltime and part time :");
            UC3_Parttime_wage.get_parttimewage();
            Console.ReadKey();
            Console.WriteLine("****************************************************************");

            Console.WriteLine("Output of UC4");
            Console.WriteLine("Get wage of employee fulltime and part time using switch case :");
            UC4_switch.get_switchwage();
            Console.WriteLine("*****************************************************************");

            Console.WriteLine("Output of UC5");
            Console.WriteLine("Get wage of employee wage for 20 days in month :");
            UC5_wagesfor20days.wage_20day();
            Console.WriteLine("*****************************************************************");

            Console.WriteLine("Output of UC6");
            Console.WriteLine("Get wage of employee wage for max 100 hours and till 20 days in month :");
            UC6_Wagetill100Hrsor20days.wage_20day();
            Console.ReadKey();
            Console.WriteLine("****************************************************************");

            Console.WriteLine("Output of UC7");
            Console.WriteLine("Get wage of employee using return mehod:");
            UC7_wageclassmethod.wage_classmethod();
            Console.ReadKey();

            
            Console.WriteLine("***************************************************************");
            Console.WriteLine("Output of UC8");
            Console.WriteLine("Get wage of employee using parameters:");
            UC8_withparameters.wage_withparams("xyz", 10, 20, 8);
            Console.ReadKey();
        }
    }
}
