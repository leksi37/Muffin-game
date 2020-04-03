using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Movement : MonoBehaviour
{
    private Vector2 min;
    private Vector2 max;
    private Vector2 yRotationRange;
    public float lerpSpeed = 0.01f;
    private Vector3 _newPosition;
    private Quaternion _newRotation;

    private void Awake()
    {

       _newPosition = transform.position;
       _newRotation = transform.rotation;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _newPosition, Time.deltaTime * lerpSpeed);
        transform.rotation = Quaternion.Lerp(transform.rotation, _newRotation, Time.deltaTime * lerpSpeed);
    
        if(Vector3.Distance(transform.position, _newPosition) < 5f)
        {
            GetNewPosition();
        }
    }

    void GetNewPosition()
    {
        var xPos = Random.Range(min.x, max.x);
        var zPos = Random.Range(min.y, max.y);
        _newRotation = Quaternion.Euler(0, Random.Range(yRotationRange.x, yRotationRange.y), 0);
        _newPosition = new Vector3(xPos, 0, zPos);
    }
}
