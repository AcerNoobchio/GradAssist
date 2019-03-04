using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GradAssistASP.Models;

namespace GradAssistASP.DAL
{
    public class GradAssistInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<GradAssistContext>
    {
        
            protected override void Seed(GradAssistContext context)
            {
                var students = new List<Student>
            {
            new Student{E_Num="12345678", F_Name="First", M_Name="Middle", L_Name="Last", Hours=12, Email="email@email.com", Address_ID=0},
            new Student{E_Num="65498132", F_Name="Ed", M_Name="Mid", L_Name="Garcia", Hours=30, Email="email@email.com", Address_ID=5},
            new Student{E_Num="64651382", F_Name="Pat", M_Name="Patch", L_Name="Patchley", Hours=45, Email="email@email.com", Address_ID=2}


            };

                students.ForEach(s => context.Students.Add(s));
                context.SaveChanges();
                
        
    }
}