using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenLib
{
	public class Exam
	{
		public string ämne;

		Dictionary<Student, string> Students = new Dictionary<Student, string>();
		List<Student> StudentsList = new List<Student>();

		public Exam(string ämne)
		{
			this.ämne = ämne;
		}

		public void Assign(Student student)
		{
			StudentsList.Add(student);
			Students.Add(student, "Inget betyg");
		}

		public void Grade(Student student, string betyg)
		{
			Students[student] = betyg;
		}

		public Dictionary<string, int> GenerateStatistics()
		{
			Dictionary<string, int> Statistik = new Dictionary<string, int>();
			Statistik.Add("IG", 0);
			Statistik.Add("G", 0);
			Statistik.Add("VG", 0);


			foreach (var student in Students)
			{
				Statistik[student.Value]++;
			}

			return Statistik;
		}
	}
}
