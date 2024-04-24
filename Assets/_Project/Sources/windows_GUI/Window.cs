using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class Window : MonoBehaviour
{
    [SerializeField] protected Button _nextWindowButton;

    public event Action OnNextWindowButtonClick; 
    
    private void Awake()
    {
        Assert.IsNotNull(_nextWindowButton);
    }

    private void OnEnable()
    {
        _nextWindowButton.onClick.AddListener(NextWindowButtonClicked);
    }

    private void OnDisable()
    {
        _nextWindowButton.onClick.RemoveListener(NextWindowButtonClicked);
    }

    public virtual void Close()
    {
        gameObject.SetActive(false);
    }

    public virtual void Open()
    {
        gameObject.SetActive(true);
    }

    private void NextWindowButtonClicked()
    {
        OnNextWindowButtonClick?.Invoke();
    }
}
