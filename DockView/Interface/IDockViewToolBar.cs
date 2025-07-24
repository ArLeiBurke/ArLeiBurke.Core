using System.Collections.ObjectModel;


namespace ArLeiBurke.Core.DockView.Interface
{
	public interface IDockViewToolBar
	{

		ObservableCollection<DockViewToolbarModel> UpCollections { get;set;}

		void InitializeUpCollections();


	}
}
