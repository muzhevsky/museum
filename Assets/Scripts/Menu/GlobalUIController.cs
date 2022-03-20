using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GlobalUIController : MonoBehaviour
{
    [SerializeField] Block menuBlock;
    [SerializeField] Block activeBlock;
    public void LoadBlock(Block block)
    {
        block.SetActive(true);
        activeBlock.SetActive(false);
        activeBlock = block;
    }
    
}
