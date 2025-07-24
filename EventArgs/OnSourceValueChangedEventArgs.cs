using System;

namespace ArLeiBurke.Core.Eventargs
{

	// Wrapper 中的 Property 发生改变的时候  会 Raise 对应的事件，Raise 对应事件之前会创建 下面的这个自定义的事件参数！！！

	public class OnSourceValueChangedEventArgs<T> : EventArgs
	{
		public string PropertyName { get; set; }	

		public T NewValue { get; set; }		

		public OnSourceValueChangedEventArgs(string propertyName, T newValue)
		{
			this.PropertyName = propertyName;
			this.NewValue = newValue;
		}
    }
}
