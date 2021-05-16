using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
	public interface IOwner
	{
		string FIO { get; set; }
		string birth_Date { get; set; }
		string passport_Data { get; set; }
		string sex { get; }
	}

	public interface IFactory
	{
		IOwner CreateOwner(string FIO, string birth_Date, string passport_Data);
	}

	public class Man : IOwner
	{
		public string FIO { get; set; }
		public string birth_Date { get; set; }
		public string passport_Data { get; set; }
		public string sex { get; }

		public Man(string fIO, string Birth_Date, string Passport_Data)
		{
			FIO = fIO;
			birth_Date = Birth_Date;
			passport_Data = Passport_Data;
			sex = "Man";
		}
	}

	public class Woman : IOwner
	{
		public string FIO { get; set; }
		public string birth_Date { get; set; }
		public string passport_Data { get; set; }
		public string sex { get; }

		public Woman(string fIO, string Birth_Date, string Passport_Data)
		{
			FIO = fIO;
			birth_Date = Birth_Date;
			passport_Data = Passport_Data;
			sex = "Woman";
		}
	}

	public class ManFactory : IFactory
	{
		public IOwner CreateOwner(string fIO, string Birth_Date, string Passport_Data)
		{
			return new Man(fIO, Birth_Date, Passport_Data);
		}
	}

	public class WomanFactory : IFactory
	{
		public IOwner CreateOwner(string fIO, string Birth_Date, string Passport_Data)
		{
			return new Woman(fIO, Birth_Date, Passport_Data);
		}
	}
}
