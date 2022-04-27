using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffectGenerator : MonoBehaviour
{
    [SerializeField] GameObject explosionPrefab;
    [SerializeField] Transform explosionContainer;
    private void Start()
    {
        print("aaa");
        if(gameObject.activeInHierarchy) StartCoroutine(SpawnExplosion());
    }
    IEnumerator SpawnExplosion()
    {
        GameObject inst = Instantiate(explosionPrefab);
        inst.transform.parent = explosionContainer;
        inst.transform.localPosition = new Vector3(Random.Range(-700, 700), Random.Range(-400, 400), 0);
        yield return new WaitForSeconds(Random.Range(0.4f, 1.8f));
        if (gameObject.activeInHierarchy) StartCoroutine(SpawnExplosion());
    }
}
