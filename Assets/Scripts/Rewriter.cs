using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Rewriter : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private string _message1;
    [SerializeField] private string _message2;
    [SerializeField] private string _message3;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_message1, _duration))
            .Append(_text.DOText(_message2, _duration).SetRelative())
            .Append(_text.DOText(_message3, _duration, true, ScrambleMode.All))
            .SetLoops(_repeats, _loopType);
    }
}