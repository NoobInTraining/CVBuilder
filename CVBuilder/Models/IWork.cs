using System.Collections.Generic;

namespace CVBuilder.Models
{
	class IWork : Event
    {
		#region [ City ]

		string City { get; set; }

		#endregion [ City ] 

		#region [ Employer ]

		/// <summary>
		/// The name of the company wich employed you
		/// </summary>
		string Employer { get; set; }

		#endregion [ Employer ] 

		#region [ TimeModel ]

		/// <summary>
		/// Parttime/Fulltime work ect.
		/// </summary>
		string TimeModel { get; set; }

		#endregion [ TimeModel ] 

		#region [ JobDescription ]

		/// <summary>
		/// 
		/// </summary>
		string JobDescription { get; set; }

		#endregion [ JobDescription ] 

		#region [ ReasonWhyItEnded ]

		/// <summary>
		/// Why did the work contract get terminated
		/// </summary>
		string ReasonWhyItEnded { get; set; }

		#endregion [ ReasonWhyItEnded ] 

		#region [ Notes ]

		/// <summary>
		/// Any notes concerning work there
		/// </summary>
		IEnumerable<string> Notes { get; set; }

		#endregion [ Notes ] 
	}
}
