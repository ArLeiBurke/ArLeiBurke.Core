

namespace ArLeiBurke.Core.Attribute
{
	/*
被此Attribute所标记的控件，可以自动的显示在对应的 DockView 上面！！！！
*/
	public class DockViewOnlineAttribute : System.Attribute
	{
		// 指示应该停靠在哪一个 DockView 上面
		public string Side { get; set; }

		// 指示 DockView 上面应该显示的Header ！！！！
		public string Header { get; set; }

		public DockViewOnlineAttribute(string Side, string Header)
		{
			this.Side = Side;
			this.Header = Header;
		}

	}

}
