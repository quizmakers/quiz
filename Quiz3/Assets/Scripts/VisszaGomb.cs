using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VisszaGomb : MonoBehaviour
{
    // Start is called before the first frame update
    public void Visszamenu() {
        SceneManager.LoadScene ("SampleScene");   
    }

}
