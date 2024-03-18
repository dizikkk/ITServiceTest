using UnityEngine;

namespace ITServiceTest
{
    [CreateAssetMenu(fileName = "BallMovementConfig", menuName = "Game/Ball/New BallMovementConfig", order = 0)]
    public class BallMovementConfig : ScriptableObject
    {
        public float startedSpeed;
    }
}