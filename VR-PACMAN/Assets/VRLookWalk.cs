using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookWalk : MonoBehaviour
{
    public Transform vrCamera;

    public float toggleAngle = 0.0f;

    public float speed = 2.0f;

    public bool moveForward;

    public bool camAng;

    //Camera  

    //Application.LoadLevel("scene1"); camera.position = (4,20,5);

    private CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {

        cc = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
       moveForward = vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f ? true : false;

        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * speed);
        }

   
    }
}
