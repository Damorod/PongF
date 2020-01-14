using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    public Ball ball;
    public Palet palet;
    public Palet1 palet1;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ball);
        Instantiate(palet);
        Instantiate(palet1);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
