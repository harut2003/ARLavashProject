using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadyLavashPut : MonoBehaviour
{
    public GameObject ReadyHandLavash;
    public GameObject ReadyLavash;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (ReadyHandLavash.activeSelf && Vector3.Distance(ReadyHandLavash.transform.position, transform.position) <= 20)
        {
            ReadyHandLavash.SetActive(false);
            ReadyLavash.GetComponent<MeshRenderer>().material.color = ReadyHandLavash.GetComponent<MeshRenderer>().material.color;
            ReadyLavash.SetActive(true);
        }
    }
}
