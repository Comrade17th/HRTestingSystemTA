using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TestsListMenu : Window
{
    [SerializeField] private Button _voiceTest;
    [SerializeField] private Button _gerchikTest;

    public event Action VoiceTestButtonClicked;
    public event Action GerchikTestButtonClicked;

    private void OnEnable()
    {
        _voiceTest.onClick.AddListener(OnVoiceTestButtonClick);
        _gerchikTest.onClick.AddListener(OnGerchikTestButtonClick);
    }

    private void OnDisable()
    {
        _voiceTest.onClick.RemoveListener(OnVoiceTestButtonClick);
        _gerchikTest.onClick.RemoveListener(OnGerchikTestButtonClick);
    }

    private void OnVoiceTestButtonClick()
    {
        VoiceTestButtonClicked?.Invoke();
    }

    private void OnGerchikTestButtonClick()
    {
        GerchikTestButtonClicked?.Invoke();
    }
}
