using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Answer : MonoBehaviour
{
    [SerializeField] protected Text _text; 
    //protected string _text { get; set; }
    
    public string Text { get => _text.text;}

    public abstract int GetValue();
    public abstract void SetValue(int value);

    public void SetText(string text)
    {
        _text.text = text;
    }
}
