using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Data
{
    public class User
    {
        #region public member
        public string UserName { get; set; }
       

        public int UserID { get; set; }
        #endregion
       
        
    # region constructor
        public User()
        {
            UserName = "guest";
            Password = "admin";
           
        }

        /// <summary>
        /// Create user with user name and Password
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        public User(string userName,string passWord)

        {
            UserName = userName;
            Password = passWord;

            
        }
    #endregion 

        #region private member
        public string Password { get; set; }
#endregion 


        #region public method

        public void authenticat()
        {
            
            if((UserName=="admin")&&(Password=="admin"))
            {
                Console.WriteLine("you are administrator",UserName);
            }
            else if((UserName == "User") && (Password == "Pass"))
            {
                Console.WriteLine("you are normal user");

            }
            else
            {
                Console.WriteLine("you are  in valid user");
            }
        }
        #endregion

    }
}
