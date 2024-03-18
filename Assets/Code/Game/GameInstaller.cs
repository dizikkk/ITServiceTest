using UnityEngine;
using Zenject;

namespace ITServiceTest
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField]
        private UIService uiServicePrefab;
        
        [SerializeField]
        private WorldTimeService worldTimeServicePrefab;
        
        [SerializeField]
        private RestartGameService restartGameServicePrefab;
        
        [SerializeField]
        private ScoreService scoreServicePrefab;
        
        [SerializeField]
        private ExitGameService exitGameServicePrefab;
        
        public override void InstallBindings()
        {
            BindUIService();
            BindWorldTimeService();
            BindRestartGameService();
            BindScoreService();
            BindExitGameService();
        }

        private void BindUIService() => 
            Container.Bind<IUIService>().To<UIService>().FromInstance(uiServicePrefab).AsSingle();

        private void BindWorldTimeService() => 
            Container.BindInterfacesTo<WorldTimeService>().FromComponentInNewPrefab(worldTimeServicePrefab).AsSingle();
        
        private void BindRestartGameService() => 
            Container.BindInterfacesTo<RestartGameService>().FromComponentInNewPrefab(restartGameServicePrefab).AsSingle();
        
        private void BindScoreService() => 
            Container.Bind<IScoreService>().To<ScoreService>().FromInstance(scoreServicePrefab).AsSingle();
        
        private void BindExitGameService() => 
            Container.BindInterfacesTo<ExitGameService>().FromComponentInNewPrefab(exitGameServicePrefab).AsSingle();
    }
}