
using System;
using System.Collections.Generic;

namespace ArLeiBurke.Core.Interface
{
	public interface IEventAggregator
	{

		Dictionary<Type, List<Action<object>>> Subscribers { get; set; }

		void Subscribe<TEvent>(Action<TEvent> action);

		void Publish<TEvent>(TEvent eventToPublish);


	}
}
