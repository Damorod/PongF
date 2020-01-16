using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    float speed = 5;

    public float height;
    public Vector2 direcction;

    // Start is called before the first frame update
    void Start()
    {
        direcction = Vector2.one.normalized;
        height = transform.localScale.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direcction * speed * Time.deltaTime);

        if (transform.position.y < Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y + height / 2 && direcction.y < 0)
        {
            direcction.y = -direcction.y;
            Sounds.Play("GOLPE_PARED");
            speed += 0.5f;
        }
        if (transform.position.y > Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).y - height / 2 && direcction.y > 0)
        {
            direcction.y = -direcction.y;
            Sounds.Play("GOLPE_PARED");
            speed += 0.5f;

        }

        if (transform.position.x < Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x + height / 2 && direcction.x < 0)
        {
            Sounds.Play("PUNTO");
            transform.position = new Vector2(0,0);
            direcction = new Vector2(Random.Range(0, 2) * 2 - 1, 1).normalized;
            ScoreIzq.scoreDer++;
            speed = 5;
        }
        if (transform.position.x > Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).x - height / 2 && direcction.x > 0)
        {
            Sounds.Play("PUNTO");
            transform.position = new Vector2(0, 0);
            direcction = new Vector2(Random.Range(0, 2) * 2 - 1, -1).normalized;
            ScoreIzq.scoreIzq++;
            speed = 5;
        }
    }


    public Vector2 getPos()
    {
        return transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Palet"))
        {
            Sounds.Play("GOLPE_PALETA");
            direcction.x = -direcction.x;
        }
        else if(collision.gameObject.CompareTag("Palet1"))
        {
            Sounds.Play("GOLPE_PALETA");
            direcction.x = -direcction.x;
        }
    }
}
