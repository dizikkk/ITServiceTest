using System;
using UnityEngine;

namespace ITServiceTest
{
    public class ScoreService : MonoBehaviour, IScoreService
    {
        public event Action<GoalType> onScoreChanged;

        public void HandleOnScoreChanged(GoalType goalType) => onScoreChanged?.Invoke(goalType);
    }
}