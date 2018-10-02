using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Models
{
	interface ICV
	{
		#region [ Work ]

		/// <summary>
		/// 
		/// </summary>		
		IEnumerable<Work> Work { get; set; }

		#endregion [ Work ]

		#region [ Education ]

		/// <summary>
		/// 
		/// </summary>		
		IEnumerable<Education> Education { get; set; }

		#endregion [ Education ]

		#region [ Projects ]

		/// <summary>
		/// 
		/// </summary>		
		IEnumerable<Project> Projects { get; set; }

		#endregion [ Projects ]
	}
}
