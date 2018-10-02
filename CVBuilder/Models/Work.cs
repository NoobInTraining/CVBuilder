using System.Collections.Generic;

namespace CVBuilder.Models
{
	class Work : Event
    {
		#region [ City ]

		public string City { get; set; }

		#endregion [ City ] 

		#region [ Employer ]

		/// <summary>
		/// The name of the company wich employed you
		/// </summary>
		public string Employer { get; set; }

		#endregion [ Employer ] 

		#region [ TimeModel ]

		/// <summary>
		/// Parttime/Fulltime work ect.
		/// </summary>
		public string TimeModel { get; set; }

		#endregion [ TimeModel ] 

		#region [ JobDescription ]

		/// <summary>
		/// 
		/// </summary>
		public string JobDescription { get; set; }

		#endregion [ JobDescription ] 

		#region [ ReasonWhyItEnded ]

		/// <summary>
		/// Why did the work contract get terminated
		/// </summary>
		public string ReasonWhyItEnded { get; set; }

		#endregion [ ReasonWhyItEnded ] 

		#region [ Notes ]

		/// <summary>
		/// Any notes concerning work there
		/// </summary>
		public IEnumerable<string> Notes { get; set; }

		#endregion [ Notes ] 
	}
}
