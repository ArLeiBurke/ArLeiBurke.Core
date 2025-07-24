using ArLeiBurke.Core.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace ArLeiBurke.Core.Module
{
	public class EventAggregator: IEventAggregator
	{
		public Dictionary<Type, List<Action<object>>> Subscribers { get; set; }

		public EventAggregator()
		{
			Subscribers = new Dictionary<Type, List<Action<object>>>();

		}

		// 订阅事件
		public void Subscribe<TEvent>(Action<TEvent> action)
		{
			if (!Subscribers.ContainsKey(typeof(TEvent)))
			{
				Subscribers[typeof(TEvent)] = new List<Action<object>>();
			}

			Subscribers[typeof(TEvent)].Add(e => action((TEvent)e));
		}

		// 发布事件
		public void Publish<TEvent>(TEvent eventToPublish)
		{
			if (Subscribers.ContainsKey(typeof(TEvent)))
			{
				foreach (var action in Subscribers[typeof(TEvent)])
				{
					action(eventToPublish);
				}
			}
		}

	}
}
