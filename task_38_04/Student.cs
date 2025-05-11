using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_38_04
{
    class Student : IComparable
    {
        public string Surname { get; set; } 
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Group { get; set; }
        public string Birthday { get; set; } 
        public Male Male { get; set; } 

        public Student(string surname, string name, string patromic, string group, string birthday, Male male)
        {
            Surname = surname;
            Name = name;
            Patronymic = patromic;
            Group = group;
            Birthday = birthday;
            Male = male;
        }

        public Student() { }

        public override string ToString()
        {
            return $"{Surname} {Name} {Patronymic} - \"{Group}\" ({Birthday})";
        }

        public string StringMale()
        {
            switch (Male)
            {
                case Male.Male: return "Мужской"; break;
                case Male.Female: return "Женский"; break;
            }
            return null;
        }

        public int CompareTo(object? obj)
        {
            if (obj != null && obj is Student student)
            {
                return (Surname+Name+Patronymic + Group).CompareTo(student.Surname+student.Name+student.Patronymic+student.Group);
            }
            else
                throw new ArgumentException();
        }
    }
}
