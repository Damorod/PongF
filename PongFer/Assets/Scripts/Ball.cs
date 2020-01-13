using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    float speed = 5;

    float radio;
    Vector2 direcction;

    // Start is called before the first frame update
    void Start()
    {
        direcction = Vector2.one.normalized;
        radio = transform.localScale.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direcction * speed * Time.deltaTime);

        if (transform.position.y < Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y + radio / 2 && direcction.y < 0)
        {
            direcction.y = -direcction.y;
        }
        if (transform.position.y > Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).y - radio / 2 && direcction.y > 0)
        {
            direcction.y = -direcction.y;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "palet" && direcction.x < 0)
        {
            direcction.x = -direcction.x;
        }else if(collision.tag == "palet1" && direcction.x > 0)
        {
            direcction.x = -direcction.x;

        }
    }
}
