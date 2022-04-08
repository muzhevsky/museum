using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class AnimationRoundController : MonoBehaviour
{
    [SerializeField] float duration;
    [SerializeField] float rotationspeed;
    [SerializeField] List<Transform> points;
    List<Vector3> vectors;
    private void Start() { 
        vectors = new List<Vector3>();
        foreach(Transform t in points)
        {
            vectors.Add(t.localPosition);
        }
        AnimateLoop();
    }
    void AnimateLoop()
    {
        transform.DOLocalPath(new[] { vectors[2], vectors[0], vectors[1], vectors[5], vectors[3], vectors[4], vectors[0], vectors[6], vectors[7] }, duration, PathType.CubicBezier).SetEase(Ease.Linear).OnComplete(() => AnimateLoop());
    }
    void FixedUpdate()
    {
        transform.Rotate(0, 0, rotationspeed);
    }
}
