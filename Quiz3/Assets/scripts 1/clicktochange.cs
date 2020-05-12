using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clicktochange : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Random rnd = new Random();

        string[] kerdesek = new string[10];
        kerdesek[0] = "Mennyi 2x8?";
        kerdesek[1] = "Mennyi 3x4?";
        kerdesek[2] = "Mennyi 9x6?";

        //Text txtmy = GameObject.Find("Canvas/Text").GetComponent<Text>();
        Text txtmy = GameObject.Find("Canvas/Text").GetComponent<Text>();
        txtmy.text = kerdesek[1];
        
       
    }

    // Update is called once per frame
    void Update()
    {
        ScoreScript.scoreValue += 1;
    }
}
