using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start() =>
        transform.DORotate(_position, _duration).SetLoops(_repeats, _loopType).SetEase(Ease.Linear);
}