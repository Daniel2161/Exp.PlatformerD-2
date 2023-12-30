using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class CrystalManager : MonoBehaviour
{

    public int crystalCount; 
    public Text crystalText; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //crystalText.text = crystalCount.ToString(); 
        crystalText.text = "= " + crystalCount.ToString(); 
    }
}
