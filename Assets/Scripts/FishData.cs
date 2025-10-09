using UnityEngine;

[CreateAssetMenu(menuName = "FishType/Fish")]
public class FishData : ScriptableObject
{
    [SerializeField] string fishName;

    [SerializeField] int fishValue;

    [SerializeField] int fishSpeed;



}
