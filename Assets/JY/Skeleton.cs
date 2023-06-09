using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Skeleton : MonoBehaviour
{
    public static int num=0;
    public LayerMask worldLayer;
    public GameObject heart0;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject plain;
    public AudioSource audio;
    public GameObject All;
    int x = 0;
    Ray ray;
    int ground;
    int n = 0;
    private GameObject heart;
    void Start()
    {
        heart = heart0;
    }
    void Update()
    {
        Debug.Log("x = " + x);
        if (num == 1)
        {
            heart = heart1;
        }
        else if (num == 2)
        {
            heart = heart2;
        }
        else if (num == 3)
        {
            All.SetActive(false);

        }
        ray = new Ray(transform.position, Vector3.down);
        ground = LayerMask.NameToLayer("Ground");
     

    }

    void FixedUpdate()
    {
        Debug.DrawRay(transform.position, Vector3.down * 1.0f, new Color(1, 0, 0));
        if (Physics.Raycast(ray,100, 1 << ground))
        {
            num += 1;

            plain.SetActive(false);
            Debug.Log("num = " + num);
            Debug.Log("ground!");
            audio.Play();
            heart.SetActive(false);
        
        }
    }
}
