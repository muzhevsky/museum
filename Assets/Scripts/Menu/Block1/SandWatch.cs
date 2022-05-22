using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandWatch : Button
{
    Animator animator;
    bool isInteractable;
    [SerializeField] float interactionDelay;
    [SerializeField] BuildingBlockController buildingBlock;

    private void Start()
    {
        animator = GetComponent<Animator>();
        isInteractable = true;
    }

    public override void OnClick()
    {
        if (isInteractable)
        {
            animator.Play("rotating");
            isInteractable = false;
            buildingBlock.GetNextBuilding();
        }
        StartCoroutine(TurnOnInteractions());
    }

    IEnumerator TurnOnInteractions()
    {
        yield return new WaitForSeconds(interactionDelay);
        isInteractable = true;
    }
}
