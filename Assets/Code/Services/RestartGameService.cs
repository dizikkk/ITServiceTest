using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace ITServiceTest
{
    public class RestartGameService : MonoBehaviour, IRestartGameService
    {
        [SerializeField]
        private SceneAsset gameScene;
        
        private IUIService uiService;
        
        [Inject]
        public void Construct(IUIService uiService) => this.uiService = uiService;

        public void RestartGame(SceneAsset scene) => SceneManager.LoadScene(scene.name);

        public void Initialize() => uiService.onRestartButtonPressed += () => RestartGame(gameScene);

        private void OnDestroy() => uiService.onRestartButtonPressed -= () => RestartGame(gameScene);
    }
}