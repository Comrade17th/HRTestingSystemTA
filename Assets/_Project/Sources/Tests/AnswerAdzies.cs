using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class AnswerAdzies : Answer
{
    [SerializeField] private Slider _slider;

    public event Action<int> ValueChanged;

    private void Awake()
    {
        Assert.IsNotNull(_slider);
    }

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(OnSliderValueChanged);
    }

    public override int GetValue()
    {
        return (int)_slider.value;
    }

    public override void SetValue(int value)
    {
        _slider.value = value;
    }

    private void OnSliderValueChanged(float value)
    {
        ValueChanged?.Invoke((int) value);
    }
}
