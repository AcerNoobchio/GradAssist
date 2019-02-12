using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    /// <summary>
    /// The class providing basic information regarding an applying graduate (name, address, etc)
    /// </summary>
    public class Student
    {
		//variables
		public string E_Num { get; }
		public string F_Name { get; }
		public string M_Name { get; }
		public string L_Name { get; }
		public int Hours { get; }
		public string Email { get; }
		public int Address_ID { get; }

		//instance constructor 
		public Student(string e_Num, string f_Name, string m_Name, string l_Name, int hours, string email, int address_ID)
		{
			E_Num = e_Num;
			F_Name = f_Name;
			M_Name = m_Name;
			L_Name = l_Name;
			Hours = hours;
			Email = email;
			Address_ID = address_ID;
		}

		//copy constructor 
		public Student(Student stud)
		{
			E_Num = stud.E_Num;
			F_Name = stud.F_Name;
			M_Name = stud.M_Name;
			L_Name = stud.L_Name;
			Hours = stud.Hours;
			Email = stud.Email;
			Address_ID = stud.Address_ID;
		}

	}//end student
}
