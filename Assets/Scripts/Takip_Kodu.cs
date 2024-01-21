using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takip_Kodu : MonoBehaviour
{
    public GameObject karakter2;
    Vector3 aradakifark;



    void Start()
    {
        aradakifark = transform.position - karakter2.transform.position;

        //aradaki farký buluyoruz
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = karakter2.transform.position + aradakifark;
    }
}
