using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float forward = 1f;
    public float backwards = -1f;
    public float jump = 2f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, forward);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, backwards);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(0, forward, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(0, backwards, 0);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            transform.Translate(jump, 0, 0);
        }
        
    }
}
