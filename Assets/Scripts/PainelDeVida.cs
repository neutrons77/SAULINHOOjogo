using UnityEngine;
using UnityEngine.UI;

public class PainelDeVida: MonoBehaviour
{
    public Personagem personagem;
    
    public Slider sliderVidas;

    void Start()
    {
        sliderVidas.minValue = 0;
        sliderVidas.maxValue = personagem.getVida();
        
    }

    void Update()
    {
        sliderVidas.value = personagem.getVida();
    }
       
}