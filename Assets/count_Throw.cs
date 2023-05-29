using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count_Throw : MonoBehaviour
{
    public int count = 0;
    public GameObject sword;
    public GameObject rock;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (count > 3)
        {
            rock.SetActive(false);
            sword.SetActive(true);
        }
    }
    void count_plus()
    {
        count += 1;
        Debug.Log(count);
     }
}
