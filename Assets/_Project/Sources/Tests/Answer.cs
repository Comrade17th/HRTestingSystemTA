using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Answer : MonoBehaviour
{
    protected string _text;
    
    public abstract int GetValue();

    public void SetText(string text)
    {
        _text = text;
    }
}
