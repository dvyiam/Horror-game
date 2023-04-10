using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField]CharacterController cc;
    [SerializeField]Camera cam;
    public float senstivity = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 8f;
        }
        else
        {
            speed = 5f;
        }
        movement();
        mouseMovementX();
    }

    void movement()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 velocity = direction * speed;
        velocity.y -= 9.8f;
        velocity = transform.transform.TransformDirection(velocity);
        cc.Move(velocity * Time.deltaTime);
    }
    void mouseMovementX()
    {
        float mousex = Input.GetAxis("Mouse X");
        Vector3 newRotation = transform.localEulerAngles;
        newRotation.y += mousex;
        transform.localEulerAngles = newRotation;
    }

   /* IEnumerator sprintMechanism()
    {

    }*/
}
