using UnityEngine;

[CreateAssetMenu(fileName = "SceneInfo", menuName = "Persistence")]
public class SceneInfo : ScriptableObject
{
    public int crystalTotal;

    public void OnValidate()
    {
        Debug.Log(crystalTotal);
    }
}
