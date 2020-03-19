using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public Vector3 Offset;
    public bool UseOffsetValues;
    public float RotateSpeed;
    public Transform Pivot;
    //public float MinViewAngle;
    //public float MaxViewAngle;

    void Start()
    {
        if (!UseOffsetValues)
        {
            Offset = Target.position - transform.position;
        }

        Pivot.transform.position = Target.transform.position;
        Pivot.transform.parent = Target.transform;

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Get the x position of the mouse and rotate to target
        float Horizontal = Input.GetAxis("Mouse X") * RotateSpeed;
        Target.Rotate(0,0, Horizontal);

        //Get y position to rotate the pivot
        float Vertical = Input.GetAxis("Mouse Y") * RotateSpeed;
        Pivot.Rotate(-Vertical, 0, 0);

        //Limit Camera's flip rotation
        //if(Pivot.rotation.eulerAngles.x > MaxViewAngle && Pivot.rotation.eulerAngles.x < 180f)
        //{
        //    Pivot.rotation = Quaternion.Euler(MaxViewAngle, 0, 0);
        //}
        //if(Pivot.rotation.eulerAngles.x > 180 && Pivot.rotation.eulerAngles.x < 360f + MinViewAngle)
        //{
        //    Pivot.rotation = Quaternion.Euler(360f - MinViewAngle, 0, 0);
        //}

        float DesiredYAngle = Target.eulerAngles.y;
        float desiredXAngle = Pivot.eulerAngles.x;
        Quaternion Rotation = Quaternion.Euler(desiredXAngle,  DesiredYAngle+90, 0);
        transform.position = Target.position - (Rotation * Offset);
        //transform.Ro(0, Horizontal, 0);
        //transform.position = Target.position - Offset;

        if(transform.position.y < Target.position.y)
        {
            transform.position = new Vector3(transform.position.x, Target.position.y - .5f, transform.position.z);
        }

        transform.LookAt(Target);
    }

   

}
