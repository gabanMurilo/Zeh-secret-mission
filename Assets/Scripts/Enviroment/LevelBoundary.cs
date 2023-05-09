using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftside = -4;
    public static float rightside = 4.3f;
    public float internalleft;
    public float internalright;
    void Update()
    {
        internalleft = leftside;
        internalright = rightside;
    }
}
