using UnityEngine;

namespace ITServiceTest
{
    [CreateAssetMenu(fileName = "BallFactoryConfig", menuName = "Game/Factory/New BallFactoryConfig", order = 0)]
    public class BallFactoryConfig : ScriptableObject
    {
        public Ball ballPrefab;
        public Vector3 spawnPosition;
    }
}