using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block1BGAnimation : MonoBehaviour
{
    Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        animator.Play("start");
    }
}
