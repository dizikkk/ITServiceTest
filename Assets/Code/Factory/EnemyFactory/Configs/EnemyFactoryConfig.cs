using UnityEngine;

namespace ITServiceTest
{
    [CreateAssetMenu(fileName = "EnemyFactoryConfig", menuName = "Game/Factory/New EnemyFactoryConfig", order = 0)]
    public class EnemyFactoryConfig : ScriptableObject
    {
        public Enemy enemyPrefab;
        public Vector3 spawnPosition;
    }
}