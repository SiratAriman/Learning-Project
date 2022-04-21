using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float BackSpeed;
    [SerializeField] private float ForwardSpeed;
    [SerializeField] private float SideSpeed;
    private Transform Player;
   
    // Start is called before the first frame update
    void Start()
    {
        Player = this.gameObject.transform;
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
