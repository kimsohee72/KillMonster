using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    Transform target;
    public GameObject Rock;
    public LayerMask worldLayer;
    Ray ray;
    int skeleton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        ray = new Ray(transform.position, Vector3.forward);
        skeleton = LayerMask.NameToLayer("Skeleton");
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

        Debug.DrawRay(transform.position, Vector3.forward * 1.0f, new Color(0, 1, 0));
    }
}
