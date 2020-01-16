using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palet : MonoBehaviour
{
    Vector2Int nextMovement;
    float currentX;
    float currentY;
    float height;

    string input;
    // Start is called before the first frame update
    void Start()
    {
        currentX = transform.position.x;
        currentY = transform.position.y;
        height = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        input = "palet";
        //if (HandleInput())
        //{
        Move();
        //}
    }

    void Move()
    {
        float mov = Input.GetAxis(input) * Time.deltaTime * 10;
        //float movement = nextMovement.y * Time.deltaTime * 5;
        if (transform.position.y < Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y + height / 2 && mov < 0)
        {
            mov = 0;
        }
        if (transform.position.y > Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).y - height / 2 && mov > 0)
        {
            mov = 0;
        }
        transform.Translate(mov * Vector2.up);
        currentX += nextMovement.x;
        currentY += nextMovement.y;
    }

    //public bool HandleInput()
    //{
    //    if (Input.GetKey(KeyCode.UpArrow))
    //    {
    //        nextMovement = new Vector2Int(0, 1);
    //    }
    //    else if (Input.GetKey(KeyCode.DownArrow))
    //    {
    //        nextMovement = new Vector2Int(0, -1);
    //    }
    //    if (Input.GetKey(KeyCode.Escape))
    //    {
    //        return false;
    //    }
    //    return true;
    //}

    public Vector2 getPos()
    {
        return transform.position;
    }
}
