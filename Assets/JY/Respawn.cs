using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    Transform target;
    public GameObject Rock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(transform.position);

        if(transform.position.y < -0.5f)
        {
            target = Rock.GetComponent<Transform>();
            target.position = new Vector3(1.67f, 0.80f, 0.01f);
        }
    }
}
