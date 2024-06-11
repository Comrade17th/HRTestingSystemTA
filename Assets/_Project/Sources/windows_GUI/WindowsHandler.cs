using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class WindowsHandler : MonoBehaviour
{
    [SerializeField] private Window _signInWindow;
    [SerializeField] private TestsListMenu _testsListWindow;
    [SerializeField] private TestMenu _testAdzies;
    [SerializeField] private ResultMenu _resultAdziesMenu;
    [SerializeField] private VoiceWindow _testVoice;

    private void Awake()
    {
        Assert.IsNotNull(_signInWindow);
        Assert.IsNotNull(_testsListWindow);
        Assert.IsNotNull(_testAdzies);
        Assert.IsNotNull(_resultAdziesMenu);
        Assert.IsNotNull(_testVoice);
    }

    private void OnEnable()
    {
        _signInWindow.NextWindowButtonClicked += SignInButtonClick;
        _testsListWindow.NextWindowButtonClicked += AdziesButtonClick;
        _testAdzies.ShowResultsButtonClicked += AdziesResultsButtonClick;
        _resultAdziesMenu.NextWindowButtonClicked += ToMainMenu;
        _testsListWindow.VoiceTestButtonClicked += VoiceCheckMenu;
        _testVoice.MainMenuButtonClicked += ToMainMenu;
    }

    private void OnDisable()
    {
        _signInWindow.NextWindowButtonClicked -= SignInButtonClick;
        _testsListWindow.NextWindowButtonClicked -= AdziesButtonClick;
        _testAdzies.ShowResultsButtonClicked -= AdziesResultsButtonClick;
        _resultAdziesMenu.NextWindowButtonClicked -= ToMainMenu;
        _testsListWindow.VoiceTestButtonClicked -= VoiceCheckMenu;
        _testVoice.MainMenuButtonClicked -= ToMainMenu;
    }

    private void SignInButtonClick()
    {
        _signInWindow.Close();
        _testsListWindow.Open();
    }

    private void AdziesButtonClick()
    {
        _testsListWindow.Close();
        _testAdzies.Open();
    }

    private void VoiceCheckMenu()
    {
        _testsListWindow.Close();
        _testVoice.Open();
        _testVoice.GetComponent<VoiceWindow>().enabled = true;
    }

    private void AdziesResultsButtonClick()
    {
        _testAdzies.Close();
        _resultAdziesMenu.Open();
    }

    private void ToMainMenu()
    {
        Debug.Log($"To main menu");
        _signInWindow.Close();
        _testAdzies.Close();
        _resultAdziesMenu.Close();
        _testVoice.Close();
        
        _testsListWindow.Open();
    }
}
