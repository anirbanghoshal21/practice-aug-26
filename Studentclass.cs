using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q2_Array_class
{
    public class Student
    {
        private int _rollno;
    
        public int rollno
        {
            get { return _rollno; }
            set { _rollno = value; }
        }

        private string _sname;

        public string StuName
        {
            get { return _sname; }
            set { _sname = value; }
        }

        private int _marks;

        public int marks
        {
            get { return _marks; }
            set { _marks = value; }
        }

            public string City { get; set; }    
        }
    }

