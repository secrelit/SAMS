﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace finalams
{
    public class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            try
            {
                ///// ---------- NOTE ------------//////
                // this path is specific to my local system....
                // you can change this path but do not commit this file...
                string xlPath = @"E:\DOTNET PROJECTS\finalams\finalams\bin\Debug\XLSHEET\18-12-2014.xlsx";

                List<NewStaffMember> nsm = controller.SaveExcelToDatabase(xlPath);
                Console.WriteLine("Count of new members : {0}", nsm.Count);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
               
            }
            
            //PunchTimeDetails ptd = new PunchTimeDetails();
            //ptd= PunchTimeDetails.GetPunchTimeDetails("manish",new Date("11/11/2011"));
            //StaffAttendanceRecord sar = new StaffAttendanceRecord();
            //sar.GetStaffAttendanceRecord("manish",new Date("11/11/2011"));
            //Console.ReadLine();
           // string str=null;
           // Time t1 = new Time("");
           // Time t3=new Time();
           // Time t4 =new Time(" ");
           //Time t2=new Time("3:56");
           //Time t5 = new Time(str);
            //int minutes = t2 - t1;

          //  //Time t3 = new Time(minutes);
          //Console.WriteLine("Time for normal: " + t2.toString());
          // Console.WriteLine("Time for empty string " + t1.toString());
          // Console.WriteLine("Time for string with whitespace " + t4.toString());
          // Console.WriteLine("Time for default constructor " + t3.toString());
          //  Console.WriteLine("Time for null value " + t5.toString());
          // Console.WriteLine("Time for (hours minutes) and (str hours and minutes)"+t2.Hour+":"+t2.Minute );

          // Console.WriteLine("Time for (hours minutes) and (str hours and minutes)" + t1.HourString + ":" + t1.MinuteString);
           
            Console.ReadLine();
        }
    }
}
