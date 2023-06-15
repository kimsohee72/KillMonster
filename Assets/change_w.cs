using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_w : MonoBehaviour
{
    public int a = 1;
    GameObject weapon;
    public GameObject rocks;
    public GameObject sword;
    public GameObject gun;
    public GameObject skeleton;
    public GameObject cube;
    public GameObject end;
    // Start is called before the first frame update
    void Start()
    {
        weapon = rocks;
        weapon.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(a > 2){
            weapon.SetActive(false);
            weapon = sword;
            weapon.SetActive(true);
        }
        if(a>4){
            weapon.SetActive(false);
            weapon = gun;
            weapon.SetActive(true);
        }
        if (a>6){
            weapon.SetActive(false);
            skeleton.SetActive(false);
            cube.SetActive(false);
            end.SetActive(true);
        }
    }
   
}
