using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FP_TextureDuration : MonoBehaviour
{
    public float timeDuration = 2f;
    private MeshRenderer mesh;
    private Color color;


    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        timeDuration -= Time.deltaTime;
        color.a = timeDuration;


        mesh.material.color = color;

        if (timeDuration <= 0)
        {
            Destroy(transform.gameObject, 0.01f);
        }
    }
}
