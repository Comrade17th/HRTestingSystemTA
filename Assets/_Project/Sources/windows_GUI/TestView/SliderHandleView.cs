using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class SliderHandleView : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Text _text;

    private void Awake()
    {
        Assert.IsNotNull(_slider);
        Assert.IsNotNull(_text);
    }

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(WriteSliderValue);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(WriteSliderValue);
    }

    private void WriteSliderValue(float value)
    {
        _text.text = $"{(int)value}";
    }
}
