using System.Collections.Generic;

namespace CVBuilder.Models
{
	interface IProject : IEvent
    {
		#region [ ProgrammingLanguages ]

		/// <summary>
		/// The Programminglanguages used in the project
		/// </summary>
		IEnumerable<string> ProgrammingLanguages { get; set; }

		#endregion [ ProgrammingLanguages ] 

		#region [ Title ]

		/// <summary>
		/// 
		/// </summary>
		string Title { get; set; }

		#endregion [ Title ] 

		#region [ Notes ]

		/// <summary>
		/// Notes concerning the Project
		/// </summary>		
		IEnumerable<string> Notes { get; set; }

		#endregion [ Notes ]
	}
}
