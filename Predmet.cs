using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmrNal1
{
	class Predmet
	{
		public Guid PredmetID { get; set; }
		public string Naziv { get; set; }
		public int ECTS { get; set; }
		public string Semester { get; set; }

		public Predmet(Guid predmetID, string naziv, int eCTS, string semester)
		{
			PredmetID = predmetID;
			Naziv = naziv;
			ECTS = eCTS;
			Semester = semester;
		}

		public Predmet()
		{
		}
	}
}
