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
    [SerializeField] private Button _adziesTest;

    public event Action VoiceTestButtonClicked;
    public event Action GerchikTestButtonClicked;
    public event Action AdziesTestButtonClicked;

    private void OnEnable()
    {
        _voiceTest.onClick.AddListener(OnVoiceTestButtonClick);
        _gerchikTest.onClick.AddListener(OnGerchikTestButtonClick);
        _adziesTest.onClick.AddListener(OnAdziesTestButtonClick);
    }

    private void OnDisable()
    {
        _voiceTest.onClick.RemoveListener(OnVoiceTestButtonClick);
        _gerchikTest.onClick.RemoveListener(OnGerchikTestButtonClick);
        _adziesTest.onClick.RemoveListener(OnAdziesTestButtonClick);
    }

    private void OnVoiceTestButtonClick()
    {
        VoiceTestButtonClicked?.Invoke();
    }

    private void OnGerchikTestButtonClick()
    {
        GerchikTestButtonClicked?.Invoke();
    }

    private void OnAdziesTestButtonClick()
    {
        AdziesTestButtonClicked?.Invoke();
    }
}
