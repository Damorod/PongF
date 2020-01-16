using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1P : MonoBehaviour
{

    public GameObject paletDer;
    public Ball ball;
    public Palet palet;
    public Paleta1PC palet1;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ball);
        Instantiate(palet);
        Instantiate(palet1);

        paletDer = GameObject.FindWithTag("Palet1");
        paletDer.GetComponent<Palet1>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
