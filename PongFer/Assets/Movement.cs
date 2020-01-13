using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void movePos(int move)
    {
        this.transform.position = new Vector2()
    }
    public bool HandleInput()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            nextMovement = new Vector2Int(0, 1);
        }
        else (Input.GetKey(KeyCode.DownArrow))
        {
            nextMovement = new Vector2Int(0, -1);
        }
    }
}


