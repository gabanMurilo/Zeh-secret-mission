using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float leftright = 4f;
    public float jump = 8f;
    public bool isGrounded;
    static public bool canMove = false;
    public bool isjumping = false;
    public bool isFalling = false;
    public GameObject playerObject;
    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        if (canMove == true)
        {
            if (Input.GetKey(KeyCode.A))
            {
                if (this.gameObject.transform.position.x > LevelBoundary.leftside)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftright);
                }

            }

            if (Input.GetKey(KeyCode.D))
            {
                if (this.gameObject.transform.position.x < LevelBoundary.rightside)
                {
                    transform.Translate(Vector3.right * Time.deltaTime * leftright);
                }
            }

            if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
            {
                if (transform.position.y < 10f)
                {
                    GetComponent<Rigidbody>().AddForce(Vector3.up * jump, ForceMode.Impulse);
                    playerObject.GetComponent<Animator>().Play("reference_EmptyAction");
                    StartCoroutine(JumpSequence());
                }
            }
        }

    }

   void OnTriggerStay(Collider other)
    {
        isGrounded = true;
    }
   void OnTriggerExit(Collider other)
    {
        isGrounded = false;
    }
   IEnumerator JumpSequence()
   {
       yield return new WaitForSeconds(0.45f);
       isFalling = true;
       yield return new WaitForSeconds(0.56f);
       isjumping = false;
       isFalling = false;
       playerObject.GetComponent<Animator>().Play("Armature_ArmatureAction");
   }
}
