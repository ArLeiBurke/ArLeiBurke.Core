using ArLeiBurke.Core.DockView.Interface;
using System.Collections.ObjectModel;


namespace ArLeiBurke.Core.DockView
{
	public class DockViewToolBar : IDockViewToolBar
	{
		public ObservableCollection<DockViewToolbarModel> UpCollections { get; set; }	

		public virtual void InitializeUpCollections()
		{

		}

		public DockViewToolBar()
		{
			InitializeUpCollections();
		}
	}
}
