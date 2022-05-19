using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Window : MonoBehaviour
{
    [SerializeField] protected GameBlock gameBlock;
    public abstract void Setup(GameBlock block);
}
