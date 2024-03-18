using System.Linq;
using Zenject;

namespace ITServiceTest
{
    public class UIFactory : IUIFactory
    {
        private readonly DiContainer diContainer;
        private readonly UIFactoryConfig config;
        
        public UIFactory(DiContainer diContainer, UIFactoryConfig config)
        {
            this.diContainer = diContainer;
            this.config = config;
        }
        
        public void Create()
        {
            CreateCanvas<OverlayCanvas>();
            CreateCanvas<WorldCanvas>();
        }

        private void CreateCanvas<T>() where T : Canvas
        {
            Canvas canvasPrefab = config.canvasPrefabs.First(x => x is T);
            if (canvasPrefab == null) return;
            Canvas canvas = diContainer.InstantiatePrefabForComponent<T>(canvasPrefab);
            canvas.Init();
        }
    }
}
    