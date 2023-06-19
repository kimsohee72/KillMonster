using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int point;
    public bool skeleton;
    public TMP_Text UIPoint_test;

    void Update()
    {
        UIPoint_test.text = (point).ToString();
    }
}
