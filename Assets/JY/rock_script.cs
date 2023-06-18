using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock_script : MonoBehaviour
{
    public GameManager gameManager;
    Transform target;
    public GameObject Rock, enemy;
    public LayerMask worldLayer;
    Ray ray1, ray2;
    RaycastHit hitinfo;
    int skeleton;

    // Start is called before the first frame update
    void Start()
    {
        gameManager.skeleton = false;
    }

    void Update()
    {
        ray1 = new Ray(transform.position, Vector3.forward);
        ray2 = new Ray(transform.position, Vector3.down);
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
        Debug.DrawRay(transform.position, Vector3.down * 1.0f, new Color(0, 0, 1));
        if (Physics.Raycast(ray1, out hitinfo, 1.0f, 1 << skeleton) || Physics.Raycast(ray2, out hitinfo, 1.0f, 1 << skeleton))
        {
            Debug.Log("die!");
            Debug.Log(hitinfo.transform.name);
            enemy = GameObject.Find(hitinfo.transform.name);
            enemy.SetActive(false);
            if (gameManager.skeleton == false)
            {
                gameManager.point++;
                gameManager.skeleton = true;
            }
            //destroy
        }        
    }
}
