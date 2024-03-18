using ITServiceTest;
using UnityEngine;

[CreateAssetMenu(fileName = "SceneServicesConfig", menuName = "Game/Factory/New SceneServicesConfig", order = 0)]
public class SceneServicesConfig : ScriptableObject
{
    public LevelService levelServicePrefab;
}
