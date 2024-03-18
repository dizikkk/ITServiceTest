using UnityEngine;

namespace ITServiceTest
{
    [CreateAssetMenu(fileName = "EnemyMovementConfig", menuName = "Game/Enemy/New EnemyMovementConfig", order = 0)]
    public class EnemyMovementConfig : ScriptableObject
    {
        public float speed;
    }
}