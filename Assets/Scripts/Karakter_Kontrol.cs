using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Karakter_Kontrol : MonoBehaviour
{

    public Rigidbody rb;
    public float ziplamagucu;
    private bool saghareket = true;

    public float maxatlama = 2f;

 
    public float hiz;


     void Start()
    {
        Time.timeScale = 0;
        rb=GetComponent<Rigidbody>();
    }
   
  

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {

            Time.timeScale = 1;
        }
      
        transform.Translate(0f, 0f, 0.5f*hiz* Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.A))
        {
            saghareket=false;
        }
        else if(Input.GetKeyDown(KeyCode.D)) {

            saghareket = true;
        }
        hareketet();

       
        if (Input.GetKeyDown(KeyCode.Return) )
        {
            if (rb.velocity.y ==0)
            {
                rb.AddForce(Vector3.up * ziplamagucu, ForceMode.Impulse);
            }

            // Zýplama yüksekliðini sýnýrla
            transform.position = new Vector3(transform.position.x, Mathf.Max(transform.position.y, maxatlama), transform.position.z);
        }


      

    }


    void hareketet()
    {

        Vector3 hareket = new Vector3((saghareket ? 1 : -1) * hiz, 0f, 0f);
        transform.Translate(hareket * Time.deltaTime);


        float hareketaraligi = Mathf.Clamp(transform.position.x, -0.3f, 0.3f);
        transform.position = new Vector3(hareketaraligi, transform.position.y, transform.position.z);


        

    }

    }



