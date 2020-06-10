using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform Target;
    private Vector3 Offset;
    [SerializeField]
    private float RotateSpeed;
    [SerializeField]
    private Transform Pivot;
    [SerializeField]
    private float MinViewAngle;
    [SerializeField]
    private float MaxViewAngle;
    [SerializeField]
    private GameObject Aim;

    void Start()
    {
        //Set the offset between the player and the camera so that you move the camera with the same offset every time
        Offset = Target.position - transform.position;
    
        Pivot.transform.position = Pivot.transform.position;

        //Removing parent, so that we can rotate camera without rotating the character
        Pivot.transform.parent = null;

        Cursor.lockState = CursorLockMode.Locked;
    }


    void LateUpdate()
    {
            //Pivot point always moves with the player
            Pivot.transform.position = Target.transform.position;

            //Get the x position of the mouse and rotate to target
            float Horizontal = Input.GetAxis("Mouse X") * RotateSpeed;
            Pivot.Rotate(0, Horizontal, 0);

            //Get y position to rotate the pivot
            float Vertical = Input.GetAxis("Mouse Y") * RotateSpeed;
            Pivot.Rotate(-Vertical, 0, 0);

            //Limit Camera's flip rotation by restricting the pivot
            if (Pivot.rotation.eulerAngles.x > MaxViewAngle && Pivot.rotation.eulerAngles.x < 180f)
            {
                Pivot.rotation = Quaternion.Euler(MaxViewAngle, 0, 0);
            }

            if (Pivot.rotation.eulerAngles.x > 180 && Pivot.rotation.eulerAngles.x < 360f + MinViewAngle)
            {
                Pivot.rotation = Quaternion.Euler(360f - MinViewAngle, 0, 0);
            }
        
            //Apply the rotation of the pivot to the camera
            float DesiredYAngle = Pivot.eulerAngles.y;
            float desiredXAngle = Pivot.eulerAngles.x;
            Quaternion Rotation = Quaternion.Euler(desiredXAngle, DesiredYAngle + 90, 0);

            //Move the camera according to player position
            transform.position = Target.position - (Rotation * Offset);
            
            //Move the camera up so it doesn't flip
            if (transform.position.y < Target.position.y)
            {
                transform.position = new Vector3(transform.position.x, Target.position.y - .5f, transform.position.z);
            }

            //Camera should always focus on the player
            transform.LookAt(Target);        
    }
}
