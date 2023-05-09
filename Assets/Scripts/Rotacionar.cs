using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacionar : MonoBehaviour
{
    public int rotacao = 1;
    
    void Update()
    {
        transform.Rotate(0, rotacao, 0, Space.World);    
    }
}
