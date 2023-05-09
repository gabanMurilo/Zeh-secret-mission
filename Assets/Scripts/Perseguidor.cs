using UnityEngine;

public class Perseguidor : MonoBehaviour
{
    public float movespeed = 3f;
    
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * movespeed, Space.World);
    }
}