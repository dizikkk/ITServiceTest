using System;

namespace ITServiceTest
{
    public interface IScoreService
    {
        public event Action<GoalType> onScoreChanged;

        public void HandleOnScoreChanged(GoalType goalType);
    }
}