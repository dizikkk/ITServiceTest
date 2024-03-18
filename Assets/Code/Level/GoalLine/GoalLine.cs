using UnityEngine;
using Zenject;

namespace ITServiceTest
{
    public class GoalLine : MonoBehaviour
    {
        [SerializeField]
        private GoalType goalType;

        private IScoreService scoreService;

        [Inject]
        private void Construct(IScoreService scoreService) => this.scoreService = scoreService;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Ball ball))
                scoreService.HandleOnScoreChanged(goalType);
        }
    }
}