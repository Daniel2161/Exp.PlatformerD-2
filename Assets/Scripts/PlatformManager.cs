using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public static PlatformManager Instance = null; 

    [SerializeField]
    GameObject platformPrefab; 

    //[SerializeField] 

    //GameObject platformPrefabSmall;

    void Awake() 
    {
        if(Instance == null)
        {
        Instance = this; 
        }
        else if (Instance != null)
        {
        Destroy (gameObject); 
        }
    }
    // Start is called before the first frame update
    void Start()
    {
      /*  Instantiate (platformPrefab, new Vector2 (-3.58999991f,1.03999996f), platformPrefab.transform.rotation); 
        Instantiate (platformPrefab, new Vector2 (-0.37f,2.3f), platformPrefab.transform.rotation); 
        Instantiate (platformPrefab, new Vector2 (2.7f,3.09f), platformPrefab.transform.rotation); 
        Instantiate (platformPrefab, new Vector2 (8.1f,2.89f), platformPrefab.transform.rotation); */
    }

    // Update is called once per frame
    IEnumerator SpawnPlatform(Vector2 spawnPosition)
    {
        /*if(gameObject != platformPrefab)
        {
            yield return new WaitForSeconds (3f); 
            Instantiate (platformPrefabSmall, spawnPosition, platformPrefab.transform.rotation);
        }
        else*/
        
        yield return new WaitForSeconds (3f); 
        Instantiate (platformPrefab, spawnPosition, platformPrefab.transform.rotation); 
        
    }
}
