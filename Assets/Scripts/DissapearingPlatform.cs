using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapearingPlatform : MonoBehaviour
{
    public float timeToTogglePlatform = 2; 
    public float currentTime = 0; 
    public bool enabled = true; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            
            //currentTime = 0;
            currentTime += Time.deltaTime; 
            if (currentTime >= timeToTogglePlatform)
            {
                currentTime = 0; 
                TogglePlatform();
            }
        }
    }
    
    void Update()
    {
        
    }
    void TogglePlatform()
    {
        enabled = !enabled; 

        foreach(Transform child in gameObject.transform)
        {
            if (child.tag != "Player")
            {
            child.gameObject.SetActive(enabled); 
            }
        }    
    }

}
