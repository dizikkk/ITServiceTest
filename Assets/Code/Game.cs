using UnityEngine;
using Zenject;

namespace ITServiceTest
{
    public class Game : MonoBehaviour
    {
        private IGameFactory gameFactory;
        private IWorldTimeService worldTimeService;
        
        [Inject]
        public void Construct(IGameFactory gameFactory, IWorldTimeService worldTimeService)
        {
            this.gameFactory = gameFactory;
            this.worldTimeService = worldTimeService;
        }

        private void Start()
        {
            worldTimeService.UnpauseTime();
            gameFactory.CreateGameplayEntities();
            gameFactory.CreateUI();
        }
    }
}