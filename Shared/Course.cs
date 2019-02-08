﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    /// <summary>
    /// The leaf of the course tree
    /// </summary>
    class Course : AbstractCourse
    {

        public Course(String Id, String Name, bool status) : base(Id, Name, status)
        {

        }//end Course(String, String, bool) : Base (String, String, bool)

        #region Necessary Overrides
        public override void Add(AbstractCourse course)
        {
            throw new InvalidOperationException();
        }//end Add(AbstractCourse)

        public override void Remove(AbstractCourse course)
        {
            throw new InvalidOperationException();
        }//end Remove(AbstractCourse)

        public override void RemoveAt(int position)
        {
            throw new InvalidOperationException();
        }//end RemoveAt(int)
        #endregion

        #region Setters and Getters
        public String GetId()
        {
            return base.Id;
        }//end GetId()

        public String GetName()
        {
            return base.Name;
        }//end GetName()

        public bool GetStatus()
        {
            return base.status;
        }//end GetStatus()

        #endregion
    }//end Course
}
