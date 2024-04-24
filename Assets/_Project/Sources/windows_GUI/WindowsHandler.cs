using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class WindowsHandler : MonoBehaviour
{
    [SerializeField] private Window _signInWindow;
    [SerializeField] private Window _testsListWindow;

    private void Awake()
    {
        Assert.IsNotNull(_signInWindow);
        Assert.IsNotNull(_testsListWindow);
    }

    private void OnEnable()
    {
        _signInWindow.OnNextWindowButtonClick += SignInButtonClick;
    }

    private void OnDisable()
    {
        _signInWindow.OnNextWindowButtonClick -= SignInButtonClick;
    }

    private void SignInButtonClick()
    {
        _signInWindow.Close();
        _testsListWindow.Open();
    }
}
