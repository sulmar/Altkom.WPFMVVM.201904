using Altkom.ABC.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.ABC.WPFClient.Common
{

    

    public class EventAggreator : IEventAggregator
    {
        private readonly Dictionary<Type, IList<Action<object>>> hub;

        public EventAggreator()
        {
            hub = new Dictionary<Type, IList<Action<object>>>();
        }

        public void Register<T>(Action<T> action)
        {
            Type type = typeof(T);

            if (hub.ContainsKey(type))
            {
                IList<Action<object>> observers = new List<Action<object>>();

                if (hub.TryGetValue(typeof(T), out observers))
                {
                    observers.Add(new Action<object>(p => action((T)p)));
                }
            }
            else
            {
                IList<Action<object>> observers = new List<Action<object>>();

                observers.Add(new Action<object>(p => action((T)p)));

                hub.Add(type, observers);

            }

        }

        public void Send<T>(T message)
        {
            foreach (var action in hub[typeof(T)])
            {
                action?.Invoke(message);
            }
        }
    }
}
