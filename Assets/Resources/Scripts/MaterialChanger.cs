using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    public Material matchange;
    void Start()
    {
        
    }

    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "show")
        {
            matchange.SetFloat("_StencilComp", 8);
            Debug.Log(other.gameObject.tag);

        }

        if(other.gameObject.tag == "hide")
        {
            matchange.SetFloat("_StencilComp", 3);
            Debug.Log(other.gameObject.tag);

        }
    }
}
