using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    // Start is called before the first frame update
    

    public void Quit()
    {
//#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
//#else
        Application.Quit(); // ���ø����̼� ����
//#endif
    }
}
