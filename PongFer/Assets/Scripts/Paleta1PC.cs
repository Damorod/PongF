using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paleta1PC : MonoBehaviour
{

    public GameObject ball;
    public Ball bal;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindWithTag("Ball");
        bal = ball.GetComponent<Ball>();
        height = transform.localScale.y;

    }

    // Update is called once per frame
    void Update()
    {


        Vector2 target = new Vector2(transform.position.x, bal.getPos().y);
       if(bal.getPos().x > -7 && bal.getPos().x < -3)
       {
            transform.position = Vector2.MoveTowards(transform.position, target, 5 * Time.deltaTime);
       }
       else if(bal.getPos().x < 9 && bal.getPos().x > 2)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, 5 * Time.deltaTime);

        }
        else if (bal.getPos().x < 0 && bal.getPos().x > -2)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, 5 * Time.deltaTime);

        }


    }
}
