using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа2
{

	public interface ILecturer
	{
		string Chair { get; set; }
		string FullName { get; set; }
		string Step { get; }
	}

	public interface IFactory
	{
		ILecturer CreateLecturer(string chair, string fullName);
	}

	public class Professor : ILecturer
	{
		public string Chair { get; set; }
		public string FullName { get; set; }
		public string Step { get;  }

		public Professor(string chair, string fullName)
		{
			Chair = chair;
			FullName = fullName;
			Step = "Профессор";
		}
	}

	public class AssociateLecturer : ILecturer
	{
		public string Chair { get; set; }
		public string FullName { get; set; }
		public string Step { get; }

		public AssociateLecturer(string chair, string fullName)
		{
			Chair = chair;
			FullName = fullName;
			Step = "Доцент";
		}
	}

	public class ProfessorFactory : IFactory
	{
		public ILecturer CreateLecturer(string chair, string fullName)
		{
			return new Professor(chair, fullName);
		}
	}

	public class AssociateLecturerFactory : IFactory
	{
		public ILecturer CreateLecturer(string chair, string fullName)
		{
			return new AssociateLecturer(chair, fullName);
		}
	}
}
