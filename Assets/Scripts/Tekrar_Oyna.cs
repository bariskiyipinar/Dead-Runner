using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Sahneleri Yönetmemizi saðlar.
public class Tekrar_Oyna : MonoBehaviour
{

    public void yenidenoyna()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;

    }
}
