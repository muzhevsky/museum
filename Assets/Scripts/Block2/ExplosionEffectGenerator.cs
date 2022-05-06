using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffectGenerator : MonoBehaviour
{
    [SerializeField] GameObject explosionPrefab;
    [SerializeField] Transform explosionContainer;
    [SerializeField] float xOffset = 700;
    [SerializeField] float yOffset = 400;
    [SerializeField] float frequencyModifier = 1;
    [SerializeField] List<GameObject> explosions;
    private void Start()
    {
        explosions = new List<GameObject>();
        print("aaa");
        if(gameObject.activeInHierarchy) StartCoroutine(SpawnExplosion());
    }
    private void OnEnable()
    {
        StartCoroutine(SpawnExplosion());
    }
    IEnumerator SpawnExplosion()
    {
        GameObject inst = Instantiate(explosionPrefab);
        inst.transform.parent = explosionContainer;
        inst.transform.localPosition = new Vector3(Random.Range(-xOffset, xOffset), Random.Range(-yOffset, yOffset), 0);
        inst.transform.rotation = Quaternion.Euler(0,0,Random.Range(0,180));
        inst.transform.localScale = new Vector3(1, 1, 1);
        bool flag = true;
        for(int i = 0; i < explosions.Count; i++)
        {
            if (explosions[i] == null)
            {
                explosions[i] = inst;
                flag = false;
                break;
            }
        }
        if (flag) explosions.Add(inst);
        yield return new WaitForSeconds(Random.Range(0.4f, 1f)/frequencyModifier);
        if (gameObject.activeInHierarchy) StartCoroutine(SpawnExplosion());
    }
    public void TurnOff()
    {
        gameObject.SetActive(false);
        foreach (GameObject item in explosions)
        {
            Destroy(item);
        }
        explosions.Clear();
    }
}
