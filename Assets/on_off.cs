using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on_off : MonoBehaviour
{
    public GameObject A;
    public GameObject B;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (A.activeSelf == false)
        {
            B.SetActive(true);
        }
    }
}
