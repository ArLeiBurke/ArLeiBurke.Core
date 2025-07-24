

using System.Diagnostics;
using System;
using System.Linq;
using System.Reflection;

namespace ArLeiBurke.Core.Interface
{

	// NavigationControl 上面会用到的  两个！！！
	/*
	 
	 凡是实现这个接口的控件，，都要有能力自动的显示在 DockView 上面！！！ 下面是对应的代码

		通过反射的方式找到所有实现 ICapsu 的控件！！！

				var interfaceType = typeof(ICapsu);

			var types = AppDomain.CurrentDomain.GetAssemblies()
				.SelectMany(assembly =>
				{
					try
					{
						return assembly.GetTypes();
					}
					catch (ReflectionTypeLoadException ex)
					{
						return ex.Types.Where(t => t != null);
					}
				})
				.Where(type => type != null && type.IsClass && !type.IsAbstract && interfaceType.IsAssignableFrom(type))
				.ToList();

			Debug.WriteLine($"找到 {types.Count} 个类实现了 {interfaceType.Name}:");
			foreach (var type in types)
			{
				Debug.WriteLine($"- {type.FullName}");
			}





	 
	 */
	public interface ICapsu
	{
		// 用于指示 TabItem 的 Header 属性！
		string DisplayName { get;}

		// 指示 TabItem 的 Content 属性 所应该显示的内容！
		object GetControlInstance();

		string ID { get; set;}


	}




}
