using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;

public class InicioBotones : MonoBehaviour
{
    [SerializeField] GameObject quitPanel;
    
    public void BotonJugar()
    {
        MMSceneLoadingManager.LoadScene("Dificultad");
    }

    public void BotonModoFacil()
    {
        MMSceneLoadingManager.LoadScene("Nivel 1_Facil");
    }

    public void BotonModoMedio()
    {
        MMSceneLoadingManager.LoadScene("Nivel 1_Medio");
    }

    public void BotonModoDificil()
    {
        MMSceneLoadingManager.LoadScene("Nivel 1_Dificil");
    }

    public void BotonSalir()
    {
        Application.Quit();
    }

    public void BotonInicio()
    {
        MMSceneLoadingManager.LoadScene("Inicio");
    }

    public void BotonInstrucciones()
    {
        SceneManager.LoadScene("Instrucciones");
    }

    public void BotonCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void BotonInicioSinCarga()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void BotonLogros()
    {
        SceneManager.LoadScene("Logros");
    }

    public void AbrirConfirmacion()
    {
        quitPanel.SetActive(true);
    }

    public void CerrarConfirmacion()
    {
        quitPanel.SetActive(false);
    }
}
