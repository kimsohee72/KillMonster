using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_image : MonoBehaviour
{
    public GameObject XRray;
    public GameObject Background;
    public int a;
    Vector3 des = new Vector3 (0, 3, 0);
    Vector3 back_destination = new Vector3 (-6, 28, 100);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 speed = Vector3.zero;
        XRray.transform.position = Vector3.SmoothDamp(XRray.transform.position, des, ref speed, 0.1f);
        Background.transform.position = Vector3.SmoothDamp(Background.transform.position, back_destination, ref speed, 0.1f);
    }
}
