using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FadePlatform : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private BoxCollider2D boxCollider;
    // Start is called before the first frame update

    void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(CO_Fade());
    }

    IEnumerator CO_Fade()
    {
        var wait = new WaitForSeconds(0.08f);
        var color = spriteRenderer.color;
        while (spriteRenderer.color.a > float.Epsilon)
        {
            color.a -= 0.05f;
            spriteRenderer.color = color;
            yield return wait;
        }
        boxCollider.isTrigger = true;
        yield return new WaitForSeconds(2);
        while (spriteRenderer.color.a < 1)
        {
            color.a += 0.15f;
            spriteRenderer.color = color;
            yield return wait;
        }
        boxCollider.isTrigger = false;
    }

}
