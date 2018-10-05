using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Models
{
	class ExampleCV : ICV
	{
		public List<Work> work = new List<Work>();
		public List<Project> projects = new List<Project>();
		public List<Education> educations = new List<Education>();

		public ExampleCV()
		{
			work.Add(new Work { City = "ExampleCity1", Employer = "ExampleEmployer1", From = new DateTime(2018, 1, 1), JobDescription = "ExampleDescription1", ReasonWhyItEnded = "ExampleReason1", TimeModel = "FullTime", To = DateTime.Now });
			work.Add(new Work { City = "ExampleCity2", Employer = "ExampleEmployer2", From = new DateTime(2018, 1, 1), JobDescription = "ExampleDescription2", ReasonWhyItEnded = "ExampleReason2", TimeModel = "FullTime", To = DateTime.Now });
			work.Add(new Work { City = "ExampleCity3", Employer = "ExampleEmployer3", From = new DateTime(2018, 1, 1), JobDescription = "ExampleDescription3", ReasonWhyItEnded = "ExampleReason3", TimeModel = "FullTime", To = DateTime.Now });
			work.Add(new Work { City = "ExampleCity4", Employer = "ExampleEmployer4", From = new DateTime(2018, 1, 1), JobDescription = "ExampleDescription4", ReasonWhyItEnded = "ExampleReason4", TimeModel = "PartTime", To = DateTime.Now });
			work.Add(new Work { City = "ExampleCity5", Employer = "ExampleEmployer5", From = new DateTime(2018, 1, 1), JobDescription = "ExampleDescription5", ReasonWhyItEnded = "ExampleReason5", TimeModel = "PartTime", To = DateTime.Now });
			work.Add(new Work { City = "ExampleCity6", Employer = "ExampleEmployer6", From = new DateTime(2018, 1, 1), JobDescription = "ExampleDescription6", ReasonWhyItEnded = "ExampleReason6", TimeModel = "PartTime", To = DateTime.Now });

			projects.Add(new Project { From = new DateTime(2018, 1, 1), To = DateTime.Now, ProgrammingLanguages = new string[] { "C#" }, Title = "Princess Carolin Untiteled Project 1" });
			projects.Add(new Project { From = new DateTime(2018, 1, 1), To = DateTime.Now, ProgrammingLanguages = new string[] { "C#", "C++" }, Title = "Princess Carolin Untiteled Project 2" });
			projects.Add(new Project { From = new DateTime(2018, 1, 1), To = DateTime.Now, ProgrammingLanguages = new string[] { "C#", "C++", "C" }, Title = "Princess Carolin Untiteled Project 3" });
			projects.Add(new Project { From = new DateTime(2018, 1, 1), To = DateTime.Now, ProgrammingLanguages = new string[] { "C#", "C++", "C", "F#" }, Title = "Princess Carolin Untiteled Project 4" });
			projects.Add(new Project { From = new DateTime(2018, 1, 1), To = DateTime.Now, ProgrammingLanguages = new string[] { "C#", "C++", "F#" }, Title = "Princess Carolin Untiteled Project 5" });

			educations.Add(new Education { City = "ExampleCity", Country = "ExampleCountry", EducationType = "ExampleStudies", From = DateTime.Now, To = DateTime.Now, SchoolName = "ExampleSchool1" });
			educations.Add(new Education { City = "ExampleCity", Country = "ExampleCountry", EducationType = "ExampleStudies", From = DateTime.Now, To = DateTime.Now, SchoolName = "ExampleSchool2" });
			educations.Add(new Education { City = "ExampleCity", Country = "ExampleCountry", EducationType = "ExampleStudies", From = DateTime.Now, To = DateTime.Now, SchoolName = "ExampleSchool3" });
			educations.Add(new Education { City = "ExampleCity", Country = "ExampleCountry", EducationType = "ExampleStudies", From = DateTime.Now, To = DateTime.Now, SchoolName = "ExampleSchool4" });
		}

		public IEnumerable<Work> Work { get => work; set => throw new NotImplementedException(); }
		public IEnumerable<Education> Education { get => educations; set => throw new NotImplementedException(); }
		public IEnumerable<Project> Projects { get => projects; set => throw new NotImplementedException(); }
	}
}
