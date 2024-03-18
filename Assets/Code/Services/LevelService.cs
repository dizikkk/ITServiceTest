using UnityEngine;
using Zenject;

namespace ITServiceTest
{
    public class LevelService : MonoBehaviour, ILevelService
    {
        private Player player;
        private Enemy enemy;
        private Ball ball;
        private IScoreService scoreService;

        [Inject]
        private void Construct(Ball ball, Player player, Enemy enemy, IScoreService scoreService)
        {
            this.ball = ball;
            this.player = player;
            this.enemy = enemy;
            this.scoreService = scoreService;
        }

        public void Awake()
        {
            scoreService.onScoreChanged += (_) => RestartLevel();
        }

        public void RestartLevel()
        {
            ball.ResetObject();
            player.ResetObject();
            enemy.ResetObject();
        }
    }
}