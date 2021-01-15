using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gundScript : MonoBehaviour
{
    public Animator rafata_anim;
    public GameObject Rafata;
    public GameObject Rafatalavshov;
    /*SkinnedMeshRenderer skinnedMeshRenderer;
    Mesh skinnedMesh;
    int blendShapeCount;*/

    // Start is called before the frst frame update

    private void OnMouseDown()
    {
            Rafata.SetActive(true);
            rafata_anim.SetBool("Rafata", true);
            rafata_anim.SetBool("reset", false);

        if (rafata_anim.GetCurrentAnimatorStateInfo(0).IsName("rafatidle"))
        {
            Rafatalavshov.SetActive(true);
            Rafata.SetActive(false);
            gameObject.SetActive(false);
            rafata_anim.SetBool("reset", true);
            rafata_anim.SetBool("Rafata", false);
        }
    }
    void Start()
    {
        Rafata.SetActive(false);
        Rafatalavshov.SetActive(false);
        gameObject.GetComponent<BoxCollider>().enabled = false;
        /*skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        skinnedMesh = GetComponent<SkinnedMeshRenderer>().sharedMesh;
        blendShapeCount = skinnedMesh.blendShapeCount;*/
        
    }


    // Update is called once per frame
    void Update()
    {
        /*Debug.Log(transform.position.y);*/
    }
}
