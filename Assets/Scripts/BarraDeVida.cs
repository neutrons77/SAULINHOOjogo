using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida: MonoBehaviour
{
    public Slider sliderVidasRestantes;
    public Personagem personagem;
    
    public Slider sliderVidas;
    public Slider sliderEnergia;

    void Start()
    {
        if (personagem != null & sliderVidasRestantes != null)
        sliderVidas.minValue = 0;
        sliderVidas.maxValue = personagem.getVida();

        sliderEnergia.minValue = 0;
        sliderEnergia.maxValue = personagem.getEnergia();
        
    }

    void Update()
    {
        sliderVidas.value = personagem.getVida();
        sliderEnergia.value = personagem.getEnergia();
    }
       
}