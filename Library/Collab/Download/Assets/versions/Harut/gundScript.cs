using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gundScript : MonoBehaviour
{
        Animator rafata_anim;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        rafata_anim = gameObject.GetComponent<Animator>();
        rafata_anim.SetBool("Rafata", true);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
