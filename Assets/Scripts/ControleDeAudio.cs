using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControleDeAudio : MonoBehaviour
{
    public int Volume;
    public int VolumeSFX;
    public bool musica;
    
    
    public Slider volumeSlider;
    public Slider VolumeSFXSlider;
    public Toggle toggleMusica;
    public TMP_Text textoMusica;

    void Start()
    {
        musica = toggleMusica.isOn;
        Volume = (int)volumeSlider.value;
        VolumeSFX = (int)VolumeSFXSlider.value;
    }


    void Update()
    {
        musica = toggleMusica.isOn;
        Volume = (int)volumeSlider.value;
        VolumeSFX = (int)VolumeSFXSlider.value;

        if (musica == true)
        {
            textoMusica.text = "Ligado";
            textoMusica.color = Color.green;
        }
        else
        {
            textoMusica.text = "Desligado";
            textoMusica.color = Color. red;
            
        }
        
    }
}