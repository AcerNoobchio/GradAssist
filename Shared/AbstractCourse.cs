using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    /// <summary>
    /// The template (component) for the course tree
    /// </summary>
    public abstract class AbstractCourse 
    {
        protected String Id;
        protected String Name;
        protected bool status;

        #region Constructors

        /// <summary>
        /// Default constructor, sets ID to 0, status to false
        /// </summary>
        public AbstractCourse()
        {
            Id = "00000";
            Name = "None Entered";
            status = false;
        }//end AbstractCourse()

        /// <summary>
        /// Parameterized Constructor for the course
        /// </summary>
        /// <param name="IdIn"> The course ID </param>
        /// <param name="NameIn"> The Name of the course </param>
        /// <param name="statusIn"> The course Status </param>
        public AbstractCourse(String IdIn, String NameIn, bool statusIn)
        {
            this.Id = IdIn;
            this.Name = NameIn;
            this.status = statusIn;
        }//end AbstractCourse(String, String, bool)

        /// <summary>
        /// The copy constructor
        /// </summary>
        /// <param name="CourseIn"> The course object to be copied </param>
        public AbstractCourse(AbstractCourse CourseIn)
        {
            this.Id = CourseIn.Id;
            this.Name = CourseIn.Name;
            this.status = CourseIn.status;
        }//end AbstractCourse(AbstractCourse)

        #endregion

        #region Abstract Methods
        /// <summary>
        /// Abstract method to add a course to the tree
        /// </summary>
        /// <param name="course"> The course to add </param>
        public abstract void Add(AbstractCourse course);

        /// <summary>
        /// Template method to remove a course from the tree
        /// </summary>
        /// <param name="course"> The course to remove </param>
        public abstract void Remove(AbstractCourse course);

        /// <summary>
        /// Template method to remove a course at a specific position in the hosted list
        /// </summary>
        /// <param name="position"> The 0-based position from which to remove a course </param>
        public abstract void RemoveAt(int position);
        #endregion

    }//end Abstract Course
}
