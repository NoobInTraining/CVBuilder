namespace CVBuilder.Models
{
	interface IEducation : IEvent
    {
		/// <summary>
		/// The type of the education e.g. studies, training ect.
		/// </summary>
		string EducationType { get; set; }

		/// <summary>
		/// The name of the educational facility visited
		/// </summary>
		string SchoolName { get; set; }

		/// <summary>
		/// The country in wich the SchoolName is
		/// </summary>
		string Country { get; set; }

		/// <summary>
		/// The city in wich the SchoolName resides
		/// </summary>
		string City { get; set; }
	}
}
