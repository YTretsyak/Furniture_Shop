using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа2
{
	[Serializable]
	public abstract class Prototype<T>
	{
		public virtual T Clone()
		{
			return (T)MemberwiseClone();
		}

		public virtual T DeepCopy()
		{
			using (var stream = new MemoryStream())
			{
				var formatter = new BinaryFormatter
				{
					Context = new StreamingContext(StreamingContextStates.Clone)
				};
				formatter.Serialize(stream, this);
				stream.Position = 0;
				return (T)formatter.Deserialize(stream);
			}
		}
	}
	[Serializable]
	public class Discipline : Prototype<Discipline>
	{
		public string Name { get; set; }
		public string Semester { get; set; }
		public int Course { get; set; }
		public string Specialty { get; set; }
		public int LecturesAmt { get; set; }
		public int LabsAmt { get; set; }
		public string Test { get; set; }
		public ILecturer Lecturer { get; set; }

		public override string ToString()
		{
			return $"{Name}, {Semester}.{Course}, {Lecturer}";
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Discipline))
				return false;

			var item = obj as Discipline;

			return
				Name == item.Name && Semester == item.Semester && Course == item.Course &&
				Specialty == item.Specialty && LecturesAmt == item.LecturesAmt &&
				LabsAmt == item.LabsAmt && Lecturer.Equals(item.Lecturer);
		}
	}
	interface IDisciplineBuilder
	{
		void BuildName(string name);
		void BuildSemester(string semester);
		void BuildCourse(int course);
		void BuildTest(string test);
		void BuildLecturesAmt(int lecturesAmt);
		void BuildLabsAmt(int labsAmt);
		void BuildSpeciality(string speciality);
		void BuildLecturer(ILecturer lecturer);
		Discipline GetResult();
	}

	class DisciplineBuilder : IDisciplineBuilder
	{
		private Discipline discipline;

		public void BuildCourse(int course)
		{
			discipline.Course = course;
		}

		public void BuildLabsAmt(int labsAmt)
		{
			discipline.LabsAmt = labsAmt;
		}

		public void BuildLecturer(ILecturer lecturer)
		{
			discipline.Lecturer = lecturer;
		}

		public void BuildLecturesAmt(int lecturesAmt)
		{
			discipline.LecturesAmt = lecturesAmt;
		}

		public void BuildName(string name)
		{
			discipline.Name = name;
		}

		public void BuildSemester(string semester)
		{
			discipline.Semester = semester;
		}

		public void BuildSpeciality(string speciality)
		{
			discipline.Specialty = speciality;
		}

		public void BuildTest(string test)
		{
			discipline.Test = test;
		}

		public Discipline GetResult()
		{
			return discipline;
		}

		public void Reset() => discipline = new Discipline();
	}

}