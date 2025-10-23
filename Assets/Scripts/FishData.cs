using UnityEngine;

[CreateAssetMenu(menuName = "FishType/Fish")]
public class FishData : ScriptableObject
{
    [Header("Fish Stats")]
    [SerializeField] public Sprite fishIcon;
    [SerializeField] public string fishName;
    [SerializeField] public int fishSpeed;
    [SerializeField] public float fishSize;


    [Header("Fish Value Data")]
    [SerializeField] public int maxFishValue;
    [SerializeField] public int minFishValue;
    

    



}
