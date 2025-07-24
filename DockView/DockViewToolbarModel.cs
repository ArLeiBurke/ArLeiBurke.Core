using System.Windows.Input;
using System.Windows.Media;

namespace ArLeiBurke.Core.DockView
{
	public class DockViewToolbarModel
	{
		public string Content { get; set; }	

		public bool IsEnable { get; set; }	

		public ImageBrush Icon { get; set; }		

		public ICommand Command { get; set; }		


	}
}
