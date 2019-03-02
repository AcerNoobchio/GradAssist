using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    /// <summary>
    /// The top-layer class that interfaces with the ui to allow the user to interact with the system
    /// </summary>
    public class Manage
    {
        public User currentUser { get; set; }
        private List<User> AllUsers;
        public AppReviews appReviews { get; set; }// add this back in when AppReviews is complete
        public Courses courses { get; set; }// add this back in when Courses is complete
        public Criteria criteria { get; set; }// add this back in when Criteria is complete

        /// <summary>
        /// Default constructor, should populate from the database
        /// </summary>
        public Manage()
        {
            AllUsers = new List<User>();
        }

        public int LogIn(User UserIn)
        {
            int iStatus = 0;
            UserIn.status = UserStatus.active;  //Altering the passed user to coencide with a specific use
            UserIn.type = UserType.Aide;        //Will replace with an IComparable interface later for better searching
            //int iPos = AllUsers.BinarySearch(UserIn);
            int iPos = -1;
            for(int iCount = 0; iCount < AllUsers.Count; iCount++)
            {
                if(UserIn.email == AllUsers[iCount].email && UserIn.password == AllUsers[iCount].password)
                {
                    iPos = iCount;
                }
            }

            if (iPos >= 0)
            {
                currentUser = AllUsers[iPos];
            }
            else
            {
                iStatus = -1;   //Indicate that no such user was found
            }
            return iStatus;
        }//end LogIn()

        public int CreateAccount(User UserIn)
        {
            int iStatus = 0;
            if(UserIn != null)
            {
                if(UserIn.email != null && UserIn.password != null)
                {
                    UserIn.status = UserStatus.active;
                    UserIn.type = UserType.Aide;    //Aide by default, will replace with a better system later
                    AllUsers.Add(UserIn);
                    iStatus = 1;    //Success
                }
                else
                {
                    iStatus = -1;   //return if a user is not filled out properly
                }
            }
            else
            {
                iStatus = -2;       //return if a user is null
            }

            return iStatus;
        }//end CreateAccount(User)



         /// <summary>
        /// returns a string of user specific data
        /// </summary>
        public override string ToString()
        {
            return string.Format(
                "Program currently being managed by" +"\n"+
                "User ID:".PadRight(20) + "{0}\n"+
                "User Type:".PadRight(20) + "{1}\n",
                currentUser.id,
                currentUser.type);
        }
    }//end Manage
}
