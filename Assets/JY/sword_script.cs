using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword_script : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject enemy;
    public LayerMask worldLayer;
    Ray ray;
    RaycastHit hitinfo;
    int skeleton;

    // Start is called before the first frame update
    void Start()
    {
        gameManager.skeleton = false;
    }

    // Update is called once per frame
    void Update()
    {
        ray = new Ray(transform.position, Vector3.left * 0.1f + Vector3.forward * 2.0f);
        skeleton = LayerMask.NameToLayer("Skeleton");
    }

    void FixedUpdate()
    {
        Debug.DrawRay(transform.position, Vector3.left * 0.1f + Vector3.forward*2.0f, new Color(0, 0, 1));
        if(Physics.Raycast(ray, out hitinfo, 2.0f, 1 << skeleton))
        {
            Debug.Log("die_sword!");
            Debug.Log(hitinfo.transform.name);
            enemy = GameObject.Find(hitinfo.transform.name);
            enemy.SetActive(false);
            if(gameManager.skeleton == false)
            {
                gameManager.point++;
                gameManager.skeleton = true;
            }
        }
    }
}
