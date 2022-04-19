using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PlayerMovement : MonoBehaviour
{
    public float ForwardSpeed;
    public float SideSpeed;
    [SerializeField] private Transform Player;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(ForwardSpeed * Time.deltaTime * Vector3.forward);
        }
        if (Input.GetKey(KeyCode.A))
            if ( transform.position.x > LevelBoundry.LeftBoundry )
            {
                {
                    transform.Translate(SideSpeed * Time.deltaTime * Vector3.left);
                }
            }
        if (Input.GetKey(KeyCode.D))
            if ( transform.position.x < LevelBoundry.RightBoundry)
            {
                {
                    transform.Translate(SideSpeed * Time.deltaTime * Vector3.right);
                }
            }
    }
}
