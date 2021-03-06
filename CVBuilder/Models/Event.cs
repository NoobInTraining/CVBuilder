﻿using System;

namespace CVBuilder.Models
{
	abstract class Event : IEvent
    {
		/// <summary>
		/// The start month/year 
		/// </summary>
		public DateTime From { get; set; }

		/// <summary>
		/// When it ended
		/// </summary>
		public DateTime To { get; set; }
	}
}
