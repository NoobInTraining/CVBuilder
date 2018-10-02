using System.Collections.Generic;

namespace CVBuilder.Models
{
	class Project : Event
    {
		#region [ ProgrammingLanguages ]

		/// <summary>
		/// The Programminglanguages used in the project
		/// </summary>
		public IEnumerable<string> ProgrammingLanguages { get; set; }

		#endregion [ ProgrammingLanguages ] 

		#region [ Title ]

		/// <summary>
		/// 
		/// </summary>
		public string Title { get; set; }

		#endregion [ Title ] 

		#region [ Notes ]

		/// <summary>
		/// Notes concerning the Project
		/// </summary>		
		public IEnumerable<string> Notes { get; set; }

		#endregion [ Notes ]
	}
}
