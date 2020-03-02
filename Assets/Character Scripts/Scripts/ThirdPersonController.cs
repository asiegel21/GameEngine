using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    public float speed;

    private Animator animComp;
    private enum charMovement {IDLE = 0, RUN = 1, HIT = 2, DEAD = 3 };
    private int movementState;
    public Transform cam;


    // Update is called once per frame

    void Start()
    {
        animComp = this.GetComponent<Animator>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            movementState = (int)charMovement.RUN;
        }
        else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            movementState = (int)charMovement.IDLE;
        }
        else if (Input.GetKeyUp(KeyCode.RightControl) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            
        }
        else if (Input.GetKeyUp(KeyCode.RightControl) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            
        }

        animComp.SetInteger("charState", movementState);
    }

    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0f, ver) * speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }
}
