using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager1 : MonoBehaviour
{
    public void BackBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
