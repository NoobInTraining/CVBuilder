﻿using System;

namespace CVBuilder.Models
{
	interface IEvent
	{
		/// <summary>
		/// The start month/year 
		/// </summary>
		DateTime From { get; set; }

		/// <summary>
		/// When it ended
		/// </summary>
		DateTime To { get; set; }
	}
}
