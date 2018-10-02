using CVBuilder.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Viewmodels
{
    class MainWindowViewmodel : CommonLibrary.Wpf.BaseNotifyPropertyChanged
    {
		#region [ Work ]

		ObservableCollection<IWork> works;

		public ObservableCollection<IWork> Work
		{
			get
			{
				return works;
			}
			set
			{
				if (works != value)
				{
					works.CollectionChanged -= (s, e) => RaisePropertyChanged(nameof(Work));
					works = value;
					RaisePropertyChanged(nameof(Work));
					works.CollectionChanged += (s, e) => RaisePropertyChanged(nameof(Work));
				}
			}
		}

		#endregion [ Work ] 

		#region [ Projects ]

		ObservableCollection<Project> projects;

		public ObservableCollection<Project> Projects
		{
			get
			{
				return projects;
			}
			set
			{
				if (projects != value)
				{
					projects.CollectionChanged -= (s, e) => RaisePropertyChanged(nameof(Work));
					projects = value;
					RaisePropertyChanged(nameof(Work));
					projects.CollectionChanged += (s, e) => RaisePropertyChanged(nameof(Work));
				}
			}
		}

		#endregion [ Projects ] 

		#region [ Education ]

		ObservableCollection<Education> educations;

		public ObservableCollection<Education> Education
		{
			get
			{
				return educations;
			}
			set
			{
				if (educations != value)
				{
					educations.CollectionChanged -= (s, e) => RaisePropertyChanged(nameof(Education));
					educations = value;
					RaisePropertyChanged(nameof(Education));
					educations.CollectionChanged += (s, e) => RaisePropertyChanged(nameof(Education));
				}
			}
		}

		#endregion [ Education ] 


	}
}
