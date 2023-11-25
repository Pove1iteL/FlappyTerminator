using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EndScreen : Screen
{
    public event UnityAction RestartButtonCkick;

    public override void Close()
    {
        _canvasGroup.alpha = 0;
        _button.interactable = false;
    }

    public override void Open()
    {
        _canvasGroup.alpha = 1;
        _button.interactable = true;
    }

    protected override void OnButtonClick()
    {
        RestartButtonCkick?.Invoke();
    }
}
