using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class new_skeleton : MonoBehaviour
{
    GameObject skeleton;
    Vector3 des;
    int num = -1;
    int x = 0;
    static int number = 1;
    public GameObject skeleton1;
    public GameObject skeleton2;
    public GameObject skeleton3;
    public GameObject skeleton4;
    public GameObject plain;

    GameObject weapon;
    public GameObject rocks;
    public GameObject sword;
    public GameObject gun;
    public GameObject skeleton0;
    public GameObject cube;
    public GameObject end;

    // Start is called before the first frame update
    void Start()
    {
        skeleton = skeleton1;
        des = skeleton1.transform.position;
        weapon = rocks;
        weapon.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (number > 2)
        {
            weapon.SetActive(false);
            weapon = sword;
            weapon.SetActive(true);
        }
        if (number > 4)
        {
            weapon.SetActive(false);
            weapon = gun;
            weapon.SetActive(true);
        }
        if (number > 7)
        {
            weapon.SetActive(false);
            skeleton0.SetActive(false);
            cube.SetActive(false);
            end.SetActive(true);
        }

        if (num == -1){
            x = 0;
            System.Random randomObj = new System.Random();
            int randomValue = randomObj.Next(0, 4);
            Debug.Log("hello = "+number);
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
            if (x == 0)
            {
                skeleton.SetActive(true);
                x = -1;
            }
            if(skeleton.transform.position.z< -5 || skeleton.activeSelf == false)
            {
                if (skeleton.activeSelf == false)
                {
                    number++;
                }
                skeleton1.transform.position = des;
                skeleton.SetActive(false);
                num = -1;
                plain.SetActive(true);
            }
        }

        if(num == 1)
        {
            if (x == 0)
            {
                skeleton.SetActive(true);
                x = -1;
            }
            if (skeleton.transform.position.z< -5 || skeleton.activeSelf == false)
            {
                if (skeleton.activeSelf == false)
                {
                    number++;
                }
                skeleton2.transform.position = des;
                skeleton.SetActive(false);
                num = -1;
                plain.SetActive(true);
            }
        }

        if(num == 2)
        {
            if (x == 0)
            {
                skeleton.SetActive(true);
                x = -1;
            }
            if (skeleton.transform.position.z< -5 || skeleton.activeSelf == false)
            {
                if (skeleton.activeSelf == false)
                {
                    number++;
                }
                skeleton3.transform.position = des;
                skeleton.SetActive(false);
                num = -1;
                plain.SetActive(true);
            }
        }

        if(num == 3)
        {
            if (x == 0)
            {
                skeleton.SetActive(true);
                x = -1;
            }
            if (skeleton.transform.position.z< -5 || skeleton.activeSelf == false)
            {
                if (skeleton.activeSelf == false)
                {
                    number++;
                }
                skeleton4.transform.position = des;
                skeleton.SetActive(false);
                num = -1;
                plain.SetActive(true);
            }
        }
        

    }
}
