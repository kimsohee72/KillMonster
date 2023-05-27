using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Skeleton : MonoBehaviour
{
    public LayerMask worldLayer;
    Ray ray;
    int ground;
    private GameObject heart;
    void Start()
    {
        heart = GameObject.Find("heart3");
    }
    void Update()
    {
        ray = new Ray(transform.position, Vector3.down);
        ground = LayerMask.NameToLayer("Ground");
    }

    void FixedUpdate()
    {
        Debug.DrawRay(transform.position, Vector3.down * 1.0f, new Color(1, 0, 0));
        if (Physics.Raycast(ray,100, 1 << ground))
        {
            Debug.Log("ground!");
            heart.SetActive(false);
        }
    }
}
