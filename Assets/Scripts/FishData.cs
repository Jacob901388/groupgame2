using UnityEngine;

[CreateAssetMenu(menuName = "FishType/Fish")]
public class FishData : ScriptableObject
{
    [Header("Fish Stats")]
    [SerializeField] public Sprite fishIcon;
    [SerializeField] public string fishName;
    [SerializeField] public float fishSpeed;
    [SerializeField] public float fishSize;


    [Header("Fish Value Data")]
    [SerializeField] public int value;

    

    



}
