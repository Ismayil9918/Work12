using System;
using System.Collections.Generic;
using System.Text;

namespace job2022
{
    internal class Group
    {
        public string No;
        public int Limit;

        private Student[] _students;

        public Group()
        {
            _students=new Student[0];
        }
        public void AddStudent(Student student)
        {
            if (_students.Length<Limit)
            {

            }
        }
    }
}
