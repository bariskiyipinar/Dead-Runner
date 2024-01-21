using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ev_Spawn : MonoBehaviour
{
    
    public int hiz;
    

    void Update()
    {
        MoveObjects();
        hareketet();
    }

    void MoveObjects()
    {
        GameObject[] clones = GameObject.FindGameObjectsWithTag("Ev_Spawn");
        foreach (GameObject clone in clones)
        {
            clone.transform.Translate(  -0.5f*hiz * Time.deltaTime,0f, 0f);
        }
    }

    void hareketet()
    {
        float hareketaraligi = Mathf.Clamp(transform.position.x, -0.07f, -0.07f);
        transform.position = new Vector3(hareketaraligi, transform.position.y, transform.position.z);
    }

    
}
