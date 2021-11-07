using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FP_Player : MonoBehaviour
{
    private Animator animator;
    public float rotate = 360;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        animator.SetFloat("move", Input.GetAxis("Vertical"));
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotate * Time.deltaTime, 0);
    }

}
