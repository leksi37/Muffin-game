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
    public float MinViewAngle;
    public float MinZoomAngle;
    public float MaxViewAngle;

    public bool isZoom = false;
    public GameObject Aim;
    public Vector3 ZoomOffset;

    void Start()
    {
        if (!UseOffsetValues)
        {
            Offset = Target.position - transform.position;
        }

        Pivot.transform.position = Target.transform.position;
        Pivot.transform.parent = null;

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (isZoom)
            Pivot.transform.position = Target.transform.position;
        else
        {
            Pivot.transform.position = Target.transform.position;
        }          

            //Get the x position of the mouse and rotate to target
            float Horizontal = Input.GetAxis("Mouse X") * RotateSpeed;
            Pivot.Rotate(0, Horizontal, 0);

            //Get y position to rotate the pivot
            float Vertical = Input.GetAxis("Mouse Y") * RotateSpeed;
            Pivot.Rotate(-Vertical, 0, 0);

                        //Limit Camera's flip rotation
            if (Pivot.rotation.eulerAngles.x > MaxViewAngle && Pivot.rotation.eulerAngles.x < 180f)
            {
                Pivot.rotation = Quaternion.Euler(MaxViewAngle, 0, 0);
            }
        if (isZoom)
        {
            if (Pivot.rotation.eulerAngles.x > 180 && Pivot.rotation.eulerAngles.x < 360f + MinZoomAngle)
            {
                Pivot.rotation = Quaternion.Euler(360f - MinZoomAngle, 0, 0);
            }
        }
        else
        {
            if (Pivot.rotation.eulerAngles.x > 180 && Pivot.rotation.eulerAngles.x < 360f + MinViewAngle)
            {
                Pivot.rotation = Quaternion.Euler(360f - MinViewAngle, 0, 0);
            }
        }

            float DesiredYAngle = Pivot.eulerAngles.y;
            float desiredXAngle = Pivot.eulerAngles.x;
            Quaternion Rotation = Quaternion.Euler(desiredXAngle, DesiredYAngle + 90, 0);
       
        
        if (isZoom)
        {
            transform.position = Target.position - (Rotation * Offset);
            transform.position = new Vector3(transform.position.x, transform.position.y+3, transform.position.z);
            if (transform.position.y < Target.position.y)
            {
                transform.position = new Vector3(transform.position.x, Target.position.y - .5f, transform.position.z);
            }
            transform.LookAt(Aim.transform);
        }
        else
        {           
            transform.position = Target.position - (Rotation * Offset);

            if (transform.position.y < Target.position.y)
            {
                transform.position = new Vector3(transform.position.x, Target.position.y - .5f, transform.position.z);
            }

            transform.LookAt(Target);
        }      
    }
}
