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
        //public AppReviews appReviews { get; set; }// add this back in when AppReviews is complete
        //public Courses courses { get; set; }// add this back in when Courses is complete
        //public Criteria criteria { get; set; }// add this back in when Criteria is complete

        /// <summary>
        /// Default constructor
        /// </summary>
        public User() { }

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
