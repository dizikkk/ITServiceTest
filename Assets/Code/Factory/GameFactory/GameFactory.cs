using Zenject;

namespace ITServiceTest
{
    public class GameFactory : IGameFactory
    {
        private IEnemyFactory enemyFactory;
        private ILevelFactory levelFactory;
        private IPlayerFactory playerFactory;
        private IBallFactory ballFactory;
        private IUIFactory uiFactory;
        private ISceneServicesFactory sceneServicesFactory;
        
        [Inject]
        public GameFactory(
            IEnemyFactory enemyFactory, 
            ILevelFactory levelFactory, 
            IPlayerFactory playerFactory,
            IBallFactory ballFactory,
            IUIFactory uiFactory,
            ISceneServicesFactory sceneServicesFactory)
        {
            this.enemyFactory = enemyFactory;
            this.levelFactory = levelFactory;
            this.playerFactory = playerFactory;
            this.ballFactory = ballFactory;
            this.uiFactory = uiFactory;
            this.sceneServicesFactory = sceneServicesFactory;
        }

        public void CreateGameplayEntities()
        {
            CreateBall();
            CreateEnemy();
            CreateLevel();
            CreatePlayer();
            CreateSceneServices();
        }
        
        private void CreatePlayer() => playerFactory.Create();
        private void CreateEnemy() => enemyFactory.Create();
        private void CreateLevel() => levelFactory.Create();
        private void CreateBall() => ballFactory.Create();
        public void CreateUI() => uiFactory.Create();
        public void CreateSceneServices()
        {
            sceneServicesFactory.Create();
        }
    }
}