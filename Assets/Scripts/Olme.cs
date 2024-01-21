using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Olme : MonoBehaviour
{
    private int skor = 0;
    public TextMeshProUGUI Skoryazisi,bitisyazisi;
    public GameObject bitispaneli;

    void Start()
    {
        skor = 0;
       
    }

   
    void Update()
    {
     bitisyazisi.text="DEATH RUNNER \n \n Oyun Bitti! \n Skor:  " +skor.ToString();

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            bitispaneli.SetActive(true);
            Time.timeScale = 0;
        }

    }

    public void OnCollisionEnter(Collision temas)
    {

       
        if (temas.gameObject.tag == "Engeller")
        {
            Ses.ses.Pause();
            Time.timeScale = 0;
            bitispaneli.SetActive(true);

        }

        else if(temas.gameObject.tag !="Engeller")
        {
            skor++;
            Skoryazisi.text = "Score=" + skor;
            
        }

    }

    

    
}
