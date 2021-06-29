using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] string _volumeParametre = "MasterVolume";
    [SerializeField] AudioMixer _mixer;
    [SerializeField] Slider _slider;

    private void Awake()
    {
        _slider.onValueChanged.AddListener(ValueChanged);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat(_volumeParametre, _slider.value);
    }

    private void Start()
    {
        _slider.value = PlayerPrefs.GetFloat(_volumeParametre, _slider.value);
    }

    public void ValueChanged(float volume)
    {
        _mixer.SetFloat(_volumeParametre, volume);
    }
}
