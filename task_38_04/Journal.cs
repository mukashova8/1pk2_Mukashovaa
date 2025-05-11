using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace task_38_04
{
    class Journal
    {
        private List<Student> students = new(); 
        public List<Student> Students => students; 
        private string saveFileName = "Students.json"; 

        public void AddStudent(Student student)
        {
            if (student != null)
            { 
                students.Add(student); 
                students.Sort(); 
            }
        }

        public void RemoveStudent (Student student)
        {
            if (students.Contains(student)) 
                students.Remove(student);
        }

        public void Save()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            var serializationData = JsonSerializer.Serialize(students, options);
            File.WriteAllText(saveFileName, serializationData);
        }
        public void Load()
        {
            if (!File.Exists(saveFileName)) 
                return; 
            var data = File.ReadAllText(saveFileName);
            if (data != null)
                students = JsonSerializer.Deserialize<List<Student>>(data);
            else 
                students = new List<Student>();
        }
    }
}
