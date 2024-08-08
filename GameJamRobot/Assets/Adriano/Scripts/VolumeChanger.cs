using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    public Slider slidersom;
    public TextMeshProUGUI textvolume;
    public static float volgeral;
    // Start is called before the first frame update
    void Start()
    {
        volgeral = 5;
    }

    // Update is called once per frame
    void Update()
    {
        AudioListener.volume = volgeral;
        textvolume.text = volgeral.ToString();
    }

    public void somMudar()
    {
        volgeral = slidersom.value;
    }
}
