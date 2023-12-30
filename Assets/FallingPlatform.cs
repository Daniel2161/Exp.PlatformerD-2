using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    Rigidbody2D rb; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> (); 
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            PlatformManager.Instance.StartCoroutine("SpawnPlatform", 
                new Vector2 (transform.position.x, transform.position.y));
            
            Invoke ("DropPlatform", 2f); 
            
        }
        else if (col.gameObject.tag == "Ground")
        {
            Destroy (gameObject, 0f);
        }
    }
    // Update is called once per frame
    void DropPlatform()
    {
        rb.isKinematic = false; 
    }
}
