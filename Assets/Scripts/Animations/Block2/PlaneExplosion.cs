using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class PlaneExplosion : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Image image;
    private void OnEnable()
    {
        animator.speed = Random.Range(1f, 1.6f);
        transform.DOScale(Random.Range(1.5f, 2.7f), 1.5f);
        animator.Play("idle");
        StartCoroutine(DestroyCoroutine());
    }
    IEnumerator DestroyCoroutine()
    {
        float rand = Random.Range(0.3f, 0.8f);
        yield return new WaitForSeconds(rand);
        image.DOFade(0, rand);
        yield return new WaitForSeconds(rand);
        Destroy(gameObject);
    }
}
