using UnityEngine;
using Zenject;

namespace ITServiceTest
{
    public class WorldTimeService : MonoBehaviour, IWorldTimeService
    {
        private IUIService uiService;

        [Inject]
        private void Construct(IUIService uiService)
        {
            this.uiService = uiService;
        }

        public void Initialize()
        {
            uiService.onPauseButtonPressed += PauseTime;
            uiService.onPlayButtonPressed += UnpauseTime;
        }

        public void PauseTime() => Time.timeScale = 0f;

        public void UnpauseTime() => Time.timeScale = 1f;

        private void OnDestroy()
        {
            uiService.onPauseButtonPressed -= PauseTime;
            uiService.onPlayButtonPressed -= UnpauseTime;
        }
    }
}