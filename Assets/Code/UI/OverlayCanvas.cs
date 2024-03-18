using System.Linq;
using UnityEngine;
using Zenject;

namespace ITServiceTest
{
    public class OverlayCanvas : Canvas
    {
        [SerializeField]
        private Screen[] screens;

        private Screen currentScreen;

        private IUIService uiService;

        [Inject]
        private void Construct(IUIService uiService) => this.uiService = uiService;

        public override void Init()
        {
            ShowScreen<GameScreen>();
            SubscribeOnEvents();
        }

        private void ShowScreen<T>() where T : Screen
        {
            TryHideCurrentScreen();
            Screen screen = screens.First(x => x is T);
            if (screen == null) return;
            currentScreen = screen;
            screen.gameObject.SetActive(true);
            screen.Init();
        }

        private void TryHideCurrentScreen()
        {
            if (currentScreen == null) return;
            currentScreen.Hide();
        }

        private void SubscribeOnEvents()
        {
            uiService.onPauseButtonPressed += ShowScreen<PauseScreen>;
            uiService.onPlayButtonPressed += ShowScreen<GameScreen>;
        }

        private void UnsubscribeOnEvents()
        {
            uiService.onPauseButtonPressed -= ShowScreen<PauseScreen>;
            uiService.onPlayButtonPressed -= ShowScreen<GameScreen>;
        }

        private void OnDestroy() => UnsubscribeOnEvents();
    }
}