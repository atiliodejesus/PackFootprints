using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FP_Instantiate : MonoBehaviour
{
    public GameObject prefab;
    public float nextTime = 0.5f;
    public float maxHeight = 1f;
    public string[] listGrounds;

    bool wait;
    int set;


    private void Update()
    {
        if (set == 1 && !wait && Input.GetKey("up"))
        {
            Instantiate(prefab, new Vector3(transform.position.x, transform.position.y + maxHeight, transform.position.z), new Quaternion(0, transform.rotation.y, 0, transform.rotation.w));
            wait = true;
            StartCoroutine("next");
        }
    }

    IEnumerator next()
    {
        yield return new WaitForSeconds(nextTime);
        wait = false;
    }

    private void OnTriggerEnter(Collider other)
    {

        for (int c = 0; c < listGrounds.Length; c++)
        {
            if (other.gameObject.tag == listGrounds[c])
                set = 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        set = 0;
    }
}
