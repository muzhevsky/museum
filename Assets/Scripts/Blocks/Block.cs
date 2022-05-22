using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Block : MonoBehaviour
{
    [SerializeField] protected GameObject content;
    public virtual void SetActive(bool flag)
    {
        content.SetActive(flag);
    }
}
