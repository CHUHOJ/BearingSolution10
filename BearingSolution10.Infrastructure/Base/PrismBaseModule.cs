using Prism.Ioc;
using Prism.Modularity;

namespace BearingSolution10.Infrastructure.Base
{
    public class PrismBaseModule : IModule
    {

        public PrismBaseModule()
        {

        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            throw new System.NotImplementedException();
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            throw new System.NotImplementedException();
        }
    }
}
