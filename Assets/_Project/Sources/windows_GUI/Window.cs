using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class Window : MonoBehaviour
{
    [SerializeField] protected Button _nextWindowButton;

    public event Action NextWindowButtonClicked; 
    
    private void Awake()
    {
        Assert.IsNotNull(_nextWindowButton);
    }

    protected virtual void OnEnable()
    {
        _nextWindowButton.onClick.AddListener(OnNextWindowButtonClick);
    }

    protected virtual void OnDisable()
    {
        _nextWindowButton.onClick.RemoveListener(OnNextWindowButtonClick);
    }

    public virtual void Close()
    {
        gameObject.SetActive(false);
    }

    public virtual void Open()
    {
        gameObject.SetActive(true);
    }

    private void OnNextWindowButtonClick()
    {
        NextWindowButtonClicked?.Invoke();
    }
}
