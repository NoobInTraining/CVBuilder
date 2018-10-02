namespace CVBuilder.Models
{
	class Education : Event
    {
		/// <summary>
		/// The type of the education e.g. studies, training ect.
		/// </summary>
		public string EducationType { get; set; }

		/// <summary>
		/// The name of the educational facility visited
		/// </summary>
		public string SchoolName { get; set; }

		/// <summary>
		/// The country in wich the SchoolName is
		/// </summary>
		public string Country { get; set; }

		/// <summary>
		/// The city in wich the SchoolName resides
		/// </summary>
		public string City { get; set; }
	}
}
