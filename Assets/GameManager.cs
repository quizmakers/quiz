using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public Kerdes[] kerdes;
    private static List<Kerdes> megvalaszolatlankerdes;

    private Kerdes jelenlegiKerdes;
    void Start()
    {
        if (megvalaszolatlankerdes == null || megvalaszolatlankerdes.Count == 0)
        {
            megvalaszolatlankerdes = kerdes.ToList<Kerdes>();
        }

        GetRandomKerdes();
        Debug.Log(jelenlegiKerdes.teny + "a" + jelenlegiKerdes.igaz);
    }

    void GetRandomKerdes()
    {
        int randomKerdesIndex = Random.Range(0, megvalaszolatlankerdes.Count);
        jelenlegiKerdes = megvalaszolatlankerdes[randomKerdesIndex];
        megvalaszolatlankerdes.RemoveAt(randomKerdesIndex);
    }
}
