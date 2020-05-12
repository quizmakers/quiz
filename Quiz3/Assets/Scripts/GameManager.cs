using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Kerdes[] kerdes;
    private static List<Kerdes> megvalaszolatlankerdes;

    private Kerdes jelenlegiKerdes;


    [SerializeField]
    private Text tenyText;

    [SerializeField]
    private Text igazValaszText;
    [SerializeField]
    private Text hamisValaszText;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private float idoKerdesekKozott = 1f;
    void Start()
    {
        if (megvalaszolatlankerdes == null || megvalaszolatlankerdes.Count == 0)
        {
            megvalaszolatlankerdes = kerdes.ToList<Kerdes>();
        }

        SetJelenlegiKerdes();
        
    }

    void SetJelenlegiKerdes()
    {
        int randomKerdesIndex = Random.Range(0, megvalaszolatlankerdes.Count);
        jelenlegiKerdes = megvalaszolatlankerdes[randomKerdesIndex];

        tenyText.text=jelenlegiKerdes.teny;
        if (jelenlegiKerdes.igaz)
        {
            igazValaszText.text = "HELYES";
            hamisValaszText.text = "ROSSZ";
        }
        else
        {
            igazValaszText.text = "ROSSZ";
            hamisValaszText.text = "HELYES";
        }
        
    }

    IEnumerator TransitionToNextQuestion()
    {
        megvalaszolatlankerdes.Remove(jelenlegiKerdes);
        yield return new WaitForSeconds(idoKerdesekKozott);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }
    public void UserSelectTrue ()
    {
        animator.SetTrigger("Igaz");
        if (jelenlegiKerdes.igaz)
        {
            Debug.Log("HELYES!");
            ScoreScript.scoreValue += 1;
        }
        else
        {
            Debug.Log("ROSSZ!");
        }
        StartCoroutine(TransitionToNextQuestion());
    }

    public void UserSelectFalse()
    {
        animator.SetTrigger("Hamis");
        if (!jelenlegiKerdes.igaz)
        {
            Debug.Log("HELYES!");
            ScoreScript.scoreValue += 1;
        }
        else
        {
            Debug.Log("ROSSZ!");
        }
        StartCoroutine(TransitionToNextQuestion());
    }
}
