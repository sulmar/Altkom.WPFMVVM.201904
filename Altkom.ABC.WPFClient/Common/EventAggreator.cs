using Altkom.ABC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.ABC.WPFClient.Common
{
    

    public interface IEvent
    {

    }

    public interface IEventAggregator
    {
        void Register<T>(Action<T> action)
                where T : IEvent;
        void Send<T>(T message);

    }

    public class EventAggreator : IEventAggregator
    {
        private readonly Dictionary<Type, List<Action<IEvent>>> allObservers;

        public EventAggreator()
        {
            allObservers = new Dictionary<Type, List<Action<IEvent>>>();
        }

        public void Register<T>(Action<T> action)
            where T : IEvent
        {
            //  List<Action<T>> observers;

            List<Action<IEvent>> observers = new List<Action<IEvent>>();

            allObservers.TryGetValue(typeof(T), out observers);
            
            // observers.Add(action);

            // observers.Add(action);
        }

        public void Send<T>(T message)
        {
            throw new NotImplementedException();
        }
    }
}
