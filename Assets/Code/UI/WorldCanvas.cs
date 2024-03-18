using TMPro;
using UnityEngine;
using Zenject;

namespace ITServiceTest
{
    public class WorldCanvas : Canvas
    {
        [SerializeField]
        private TextMeshPro playerScoreText;
        
        [SerializeField]
        private TextMeshPro enemyScoreText;
        
        private IScoreService scoreService;

        [Inject]
        private void Construct(IScoreService scoreService) => this.scoreService = scoreService;

        public override void Init() => scoreService.onScoreChanged += ChooseScoreText;

        private void ChooseScoreText(GoalType goalType)
        {
            switch (goalType)
            {
                case GoalType.EnemyGoal:
                    ChangeScore(enemyScoreText);
                    break;
                case GoalType.PlayerGoal:
                    ChangeScore(playerScoreText);
                    break;
            }
        }
        
        private void ChangeScore(TextMeshPro scoreText)
        {
            int currentScore = int.Parse(scoreText.text) + 1;
            scoreText.text = $"{currentScore}";
        }

        private void OnDestroy() => scoreService.onScoreChanged -= ChooseScoreText;
    }
}