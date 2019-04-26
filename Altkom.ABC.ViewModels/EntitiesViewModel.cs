using Altkom.ABC.IServices;
using System.Collections.Generic;

namespace Altkom.ABC.ViewModels
{
    public class EntitiesViewModel<TEntity>  : ViewModelBase
    {
        public IEnumerable<TEntity> Entities { get; set; }

        public TEntity SelectedEntity { get; set; }

        private IEntitiesService<TEntity> entitiesService;

        public EntitiesViewModel(INavigationService navigationService, IEntitiesService<TEntity> entitiesService)
            : base(navigationService)
        {
            this.entitiesService = entitiesService;

            Load();
        }

        protected virtual void Load()
        {
            Entities = entitiesService.Get();
        }
    }
}
