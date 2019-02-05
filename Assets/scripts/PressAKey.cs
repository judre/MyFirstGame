using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressAKey : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            print("f key was pressed");
        }
    }
}
