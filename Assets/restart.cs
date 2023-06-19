using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// restart 기능을 만들자
// 재시작 할 때 image restart를 보이지 않게 하자
public class restart : MonoBehaviour
{


    public GameObject imageRestart;

    // Start is called before the first frame update
    void Start()
    {
        //활성화, 비활성화
        imageRestart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //restart 버튼을 누르면
    public void OnClickRestart()
    {
        //첫 장면을 가져오게 된다.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
