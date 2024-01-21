using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Nesne_Spawn_Et : MonoBehaviour
{


    public GameObject yol1;
    public Transform yol;



    public void OnTriggerEnter(Collider nesne)
    {
        if (nesne.gameObject.tag == "Spawn_Etme")
        {
            Instantiate(yol1, new Vector3(yol.position.x, yol.position.y, transform.position.z + 14f), Quaternion.identity);


        }

    }







}






