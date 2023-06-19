using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class shooter : MonoBehaviour
{
    public GameManager gameManager;
    public LayerMask hittableMask;
    public GameObject hitEffectPrefab, enemy, Gun;
    public Transform shootPoint;

    public float shootDelay = 0.1f;
    public float maxDistance = 100f;

    public UnityEvent<Vector3> OnShootSuccess;
    public UnityEvent OnShootFail;

    Transform target;

    private void Start()
    {
        Stop();
    }

    public void Play()
    {
        StopAllCoroutines();
        StartCoroutine(Process());
    }

    public void Stop()
    {
        StopAllCoroutines();
    }


    private IEnumerator Process()
    {
        var wfs = new WaitForSeconds(shootDelay);
        while (true)
        {
            Shoot();

            yield return wfs;
        }
    }

    private void Shoot()
    {
        if(Physics.Raycast(shootPoint.position, shootPoint.forward, out RaycastHit hitInfo, maxDistance, hittableMask))
        {
            Instantiate(hitEffectPrefab, hitInfo.point, Quaternion.identity);

            Debug.Log("die_gun!");
            Debug.Log(hitInfo.transform.name);
            enemy = GameObject.Find(hitInfo.transform.name);
            enemy.SetActive(false);
            if (gameManager.skeleton == false)
            {
                gameManager.point++;
                gameManager.skeleton = true;
            }
            gameManager.skeleton = false;

            OnShootSuccess?.Invoke(hitInfo.point);
        }
        else
        {
            var hitPoint = shootPoint.position + shootPoint.forward * maxDistance;
            OnShootSuccess?.Invoke(hitPoint);
        }
    }

    void FixedUpdate()
    {
        //Debug.Log(transform.position);

        if (transform.position.y < -0.5f)
        {
            target = Gun.GetComponent<Transform>();
            target.position = new Vector3(1.66f, 0.55f, 0.25f);
        }
    }
}
