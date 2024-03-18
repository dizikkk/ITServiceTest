using UnityEngine;

namespace ITServiceTest
{
    [CreateAssetMenu(fileName = "PlayerMovementConfig", menuName = "Game/Player/New PlayerMovementConfig", order = 0)]
    public class PlayerMovementConfig : ScriptableObject
    {
        public float speed;
    }
}