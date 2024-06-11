using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TestsListMenu : Window
{
    [SerializeField] private Button _voiceTest;

    public event Action VoiceTestButtonClicked; 

    private void OnEnable()
    {
        _voiceTest.onClick.AddListener(OnVoiceTestButtonClick);
    }

    private void OnDisable()
    {
        _voiceTest.onClick.RemoveListener(OnVoiceTestButtonClick);
    }

    private void OnVoiceTestButtonClick()
    {
        VoiceTestButtonClicked?.Invoke();
    }
}
