using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace ITServiceTest
{
    public class GameScreen : Screen
    {
        [SerializeField]
        private Button pauseButton;

        private IUIService uiService;
        
        [Inject]
        public void Construct(IUIService uiService) => this.uiService = uiService;
        
        public override void Init()
        {
            SubscribeButtons();
        }

        public override void Hide()
        {
            UnsubscribeButtons();
            gameObject.SetActive(false);
        }

        private void SubscribeButtons() => pauseButton.onClick.AddListener(uiService.HandleOnPauseButtonPressed);

        private void UnsubscribeButtons() => pauseButton.onClick.RemoveAllListeners();
    }
}