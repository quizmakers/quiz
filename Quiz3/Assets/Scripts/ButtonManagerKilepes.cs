using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManagerKilepes : MonoBehaviour
{
    public void GameButtonExit(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
