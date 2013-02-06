using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQDataContext
{
    public class Student
    {
        public int Student_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Login { get; set; }
        public int Section_ID { get; set; }
        public int Year_Result { get; set; }
        public string Course_ID { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Student_ID);
            sb.Append(" | ");
            sb.Append(this.First_Name);
            sb.Append(" | ");
            sb.Append(this.Last_Name);
            sb.Append(" | ");
            sb.Append(this.BirthDate);
            sb.Append(" | ");
            sb.Append(this.Login);
            sb.Append(" | ");
            sb.Append(this.Section_ID);
            sb.Append(" | ");
            sb.Append(this.Year_Result);
            sb.Append(" | ");
            sb.Append(this.Course_ID);

            return sb.ToString();
        }
    }
}
