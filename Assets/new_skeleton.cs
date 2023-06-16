using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class new_skeleton : MonoBehaviour
{
    GameObject skeleton;
    Vector3 des;
    int num = -1;
    public GameObject skeleton1;
    public GameObject skeleton2;
    public GameObject skeleton3;
    public GameObject skeleton4;
    public GameObject plain;
    // Start is called before the first frame update
    void Start()
    {
        skeleton = skeleton1;
        des = skeleton1.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if(num == -1){
            System.Random randomObj = new System.Random();
            int randomValue = randomObj.Next(0, 4);
            Debug.Log(randomValue);
            if(randomValue == 0){
                skeleton = skeleton1;
                num = 0;
            }
            if(randomValue == 1){
                skeleton = skeleton2;
                num = 1;
            }
            if(randomValue == 2){
                skeleton = skeleton3;
                num = 2;
            }
            if(randomValue == 3){
                skeleton = skeleton4;
                num = 3;
            }
            des = skeleton.transform.position;
        }
        
        if(num == 0)
        {
            skeleton.SetActive(true);
            if(skeleton.transform.position.z< -5){
                skeleton1.transform.position = des;
                skeleton.SetActive(false);
                num = -1;
                plain.SetActive(true);
            }
        }

        if(num == 1)
        {
            skeleton.SetActive(true);
            if(skeleton.transform.position.z< -5){
                skeleton2.transform.position = des;
                skeleton.SetActive(false);
                num = -1;
                plain.SetActive(true);
            }
        }

        if(num == 2)
        {
            skeleton.SetActive(true);
            if(skeleton.transform.position.z< -5){
                skeleton3.transform.position = des;
                skeleton.SetActive(false);
                num = -1;
                plain.SetActive(true);
            }
        }

        if(num == 3)
        {
            skeleton.SetActive(true);
            if(skeleton.transform.position.z< -5){
                skeleton4.transform.position = des;
                skeleton.SetActive(false);
                num = -1;
                plain.SetActive(true);
            }
        }
        

    }
}
