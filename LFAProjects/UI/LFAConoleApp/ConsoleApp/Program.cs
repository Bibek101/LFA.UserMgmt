using LFA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to leapfrog");

            Console.Write("Enter your name");
            string strname = Console.ReadLine();

            Console.Write("Enter your password");
            string strpass = Console.ReadLine();




            int count = 1;
            User objUser = new User();
            objUser.UserID = 1;
            objUser.UserName = "strname";
            objUser.Password = "strpass";
            objUser.authenticat();

       //     Console.WriteLine("User name of obj user is :" + objUser.UserName);
         //   Console.WriteLine("password is {0}", objUser.Password);
        //    Console.WriteLine("your count is " + count);
          //  var objUsercopy = objUser;
           // objUsercopy.UserName = "NewUser";
           // Console.WriteLine("New user name is " + objUsercopy.UserName);

//            int countcopy = count;
  //          countcopy++;
    //        Console.WriteLine("your count is " + count);
      //      Console.WriteLine("your count is " + countcopy++);





           

            //    loginUser();
            //  Console.WriteLine("press any key to exit");
            //Console.ReadLine();


            //    Console.Write("Enter your name :");

            //   string strname = Console.ReadLine();
            // Console.Write("Enter your password :");

            //string strpass = Console.ReadLine();
            //if  ((strname == "admin") && (strpass == "admin")) 
            //    {
            //   Console.Write("you are authenticated  welcome " + strname);

            //                }
            //          else
            //          {
            //          Console.Write("Enter the valid user name and password");
            //       }

            Console.ReadKey();
        }
    }
}
