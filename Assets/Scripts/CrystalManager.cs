using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class CrystalManager : MonoBehaviour
{
    //public EndTrigger et;
    public static CrystalManager instance; // Singleton pattern to ensure only one instance exists

    public SceneInfo sceneInfo;
    public int crystalCount;
    public Text crystalText;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Ensure this object persists between scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        if (sceneInfo != null)
            crystalCount = sceneInfo.crystalTotal;
    }

    // Update is called once per frame
    void Update()
    {



        crystalText.text = "= " + crystalCount.ToString();



    }

}
