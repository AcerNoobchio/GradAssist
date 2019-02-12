using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{ 
    public enum UserStatus { active = 0, inactive = 1 };
    /// <summary>
    /// A member of the grad evaluation process, one of three types, see UserType
    /// </summary>
    public class User
    {
        public int id { get; }
        public string email { get; set; }
        public string password{ get; set; }
        public UserType type { get; set; }
        public UserStatus status { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public User() { }

        /// <summary>
        /// returns a string of user specific data
        /// </summary>
        public string ToString()
        {
            return string.Format(
                "User ID:".PadRight(20) + "{0}\n"+
                "Email:".PadRight(20) + "{1}\n" +
                "User Type:".PadRight(20) + "{2}\n" +
                "User Status:".PadRight(20) + "{3}\n",
                id,
                email,
                type,
                status);
        }


    }
}
