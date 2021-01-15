using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class table : MonoBehaviour
{
    public GameObject handToast;
    public GameObject tableToast;
    Vector3 defaultPos = new Vector3(0, 0.96f, 0);
    Vector3 defaultScale = new Vector3(0.75f, 0.5f, 0.5f);
    public GameObject Rafata;
    Animator rafata_anim;
    void Start()
    {
        Rafata.SetActive(false);
        tableToast.SetActive(false);
    }

    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (handToast.activeSelf&& Vector3.Distance(handToast.transform.position, transform.position) <= 10)
        {
            handToast.SetActive(false);
            tableToast.transform.localPosition = defaultPos;
            // tableToast.transform.localScale = defaultScale;
            tableToast.SetActive(true);
            UIGame.hint.text = "սեղմիր գրտնակին";
        }
    }
}
