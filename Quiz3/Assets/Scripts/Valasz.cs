using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Valasz : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gObject;
    

    //StreamReader sr = new StreamReader(@"C:\Users\aaata\Downloads\New Unity Project\Szorzás.txt");
    public string s = "zh";

    // Start is called before the first frame update






    // Update is called once per frame

    public void TextChange()
    {
        gObject.GetComponent<Text>().text = "sdafsdf";
        ScoreScript.scoreValue += 1;
    }
}

