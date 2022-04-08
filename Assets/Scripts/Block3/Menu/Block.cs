using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] protected GameObject gObject;
    public virtual void SetActive(bool flag)
    {
        gObject.SetActive(flag);
    }
}
