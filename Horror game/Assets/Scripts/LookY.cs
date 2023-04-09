using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousey = Input.GetAxis("Mouse Y");
        Vector3 newRotation = transform.localEulerAngles;
        mousey = Mathf.Clamp(mousey, -90f, 90f);
        newRotation.x -= mousey;
        transform.localEulerAngles = newRotation;
    }
}
