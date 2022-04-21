using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform PlayerPosition;
    [SerializeField] private Vector3 CamOffset;
    private Vector3 CamPosition;
    [SerializeField] private float SmoothSpeed;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void LateUpdate()
    {
        CamPosition = PlayerPosition.position + CamOffset;
        transform.position = Vector3.Lerp(transform.position,CamPosition, SmoothSpeed) ;
    }
    
}
