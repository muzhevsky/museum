using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ExplosionEffectScript : MonoBehaviour
{
    RectTransform transform;
    Image image;
    private void Start()
    {
        transform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
        float rand = Random.Range(1.6f, 2.8f);
        transform.localScale = new Vector3(2, 2, 2);
        transform.DOScale(Random.Range(3.2f, 5.5f), rand);
        image.DOColor(Color.white, rand);
        image.DOFade(0f, rand).OnComplete(() => Destroy(gameObject));
    }
}
