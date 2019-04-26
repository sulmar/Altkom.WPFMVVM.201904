using System;
        
namespace Altkom.ABC.ViewModels
{
    public interface IEventAggregator
    {
        void Register<T>(Action<T> action);
        void Send<T>(T message);

    }

}
