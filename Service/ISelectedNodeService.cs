using System;
using System.Windows;

namespace ArLeiBurke.Core.Service
{
	public interface ISelectedNodeService
	{
		void RegisterSelectedNodeService(UIElement Element,Action<object,RoutedEventArgs> action);
	}
}
