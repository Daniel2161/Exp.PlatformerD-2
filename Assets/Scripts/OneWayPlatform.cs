using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayPlatform : MonoBehaviour
{

    public bool collision;
    public PlatformEffector2D platform;

    // Update is called once per frame
    void Update()
    {
        if (collision && Input.GetKey(KeyCode.S))
        {
            platform.surfaceArc = 0f;
            StartCoroutine(Wait());

        }

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        collision = true;
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        collision = false;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.3f);
        platform.surfaceArc = 180f;
    }

}
