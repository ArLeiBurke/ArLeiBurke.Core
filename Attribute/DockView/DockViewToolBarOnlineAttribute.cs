using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ArLeiBurke.Core.Attribute.DockView
{
	public class DockViewToolBarOnlineAttribute
	{
		// Icon 不为 null 的话就显示 Icon
		public ImageSource Icon { get; set; }		


		public string Tooltip { get; set; }		

		// Icon 为 null 的话 就显示 下面这个属性中的内容！！！！
		public string Content { get; set; }	






	}
}
