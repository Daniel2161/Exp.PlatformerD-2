using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public CrystalManager cm;
    public string sceneName;
    public bool isNextScene = true;
    public int cmTotal;
    [SerializeField]
    public SceneInfo sceneInfo;

    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.name == "Player")
        {
            //sceneInfo.isNextScene = isNextScene;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //cm.placeholder = cm.et.cmTotal;
        }

    }

}
