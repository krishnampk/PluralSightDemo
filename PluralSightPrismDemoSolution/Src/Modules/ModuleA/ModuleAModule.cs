using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ModuleA
{
    public class ModuleAModule : IModule
    {
        IRegionManager _regionManager;
        IUnityContainer _unityContainer;
        public ModuleAModule(IUnityContainer container, IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _unityContainer = container;
        }

        #region IModule Members

        public void Initialize()
        {
            // experiment with regions here...
            //_regionManager.RegisterViewWithRegion("ContentRegion", typeof(ContentView));
            _unityContainer.RegisterType<IContentView, ContentView>();
            _unityContainer.Resolve<IContentView>();
        }

        #endregion
    }
}
