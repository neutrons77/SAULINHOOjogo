using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCena : MonoBehaviour
{

    public string nomeDaCena;
    
    
    public void  Carregar()
    
    {
        SceneManager.LoadScene(nomeDaCena);
    }

   
}