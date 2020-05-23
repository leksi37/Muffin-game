using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public Transform Target;
    public float RotateSpeed;
    public Transform Pivot;
    public GameObject Player;
    public Vector3 Offset;
    public float MinViewAngle;
    public float MinZoomAngle;
    public float MaxViewAngle;

    public bool UseOffsetValues;


    void Start()
    {
        if (!UseOffsetValues)
        {
            Offset = Target.position - transform.position;
        }
  

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        //Pivot.transform.position = Target.transform.position;
        

        //Get the x position of the mouse and rotate to target
        float Horizontal = Input.GetAxis("Mouse X") * RotateSpeed;
        //Pivot.Rotate( 0f ,Horizontal, 0f);
        //transform.Rotate(0f, Horizontal, 0f);


        ////Get y position to rotate the pivot
        float Vertical = Input.GetAxis("Mouse Y") * RotateSpeed;
        //Pivot.Rotate( Vertical,0f, 0f);
        //transform.Rotate(Vertical, 0f, 0f);
        //transform.Rotate(Vertical, Horizontal, 0f, Space.Self);

        if (Pivot.rotation.eulerAngles.x > MaxViewAngle && Pivot.rotation.eulerAngles.x < 180f)
        {
            Pivot.rotation = Quaternion.Euler(MaxViewAngle, 0, 0);
        }

        if (Pivot.rotation.eulerAngles.x > 180 && Pivot.rotation.eulerAngles.x < 360f + MinViewAngle)
        {
            Pivot.rotation = Quaternion.Euler(360f - MinViewAngle, 0, 0);
        }

        float DesiredYAngle = Pivot.eulerAngles.y;
        float desiredXAngle = Pivot.eulerAngles.x;
        Quaternion Rotation = Quaternion.Euler(desiredXAngle, DesiredYAngle + 90, 0);
        transform.position = Target.position - (Rotation * Offset);



        transform.LookAt(Pivot);

    }
}
