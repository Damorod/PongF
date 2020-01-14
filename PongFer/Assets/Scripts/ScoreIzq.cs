using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreIzq : MonoBehaviour
{

    public static int scoreIzq = 0;
    public static int scoreDer = 0;

    public Text puntosIzq;
    public Text puntosDer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntosIzq.text = scoreIzq.ToString();
        puntosDer.text = scoreDer.ToString();
    }
}
