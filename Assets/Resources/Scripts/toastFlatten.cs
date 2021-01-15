using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toastFlatten : MonoBehaviour
{
    Vector3 pos;
    Vector3 scale;
    bool isReady = false;
    public GameObject handReadyToast;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log(transform.localScale);
        if (transform.localScale.y > 0.2f&& Vector3.Distance(handReadyToast.transform.position, transform.position) <= 20)
        {
            pos = transform.position - new Vector3(0, 0.05f, 0);
            scale = transform.localScale - new Vector3(0, 0.1f, 0);
            InvokeRepeating("lerpFirst", 0f, Time.deltaTime);
        }

        else if(transform.localScale.y >= 0.1 && Vector3.Distance(handReadyToast.transform.position, transform.position) <= 20)
        {
            CancelInvoke("lerpFirst");
            scale = transform.localScale + new Vector3(0, 0, 0.1f);
            InvokeRepeating("lerpSecond", 0f, Time.deltaTime);

        }

        else if (transform.localScale.x > 0.3f&&!isReady&&Vector3.Distance(handReadyToast.transform.position, transform.position) <= 20)
        {
            isReady = true;
        }

        else if (isReady&& Vector3.Distance(handReadyToast.transform.position, transform.position) <= 20)
        {
            CancelInvoke();
            handReadyToast.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    void lerpFirst()
    {
        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime);
        transform.localScale = Vector3.Lerp(transform.localScale, scale, Time.deltaTime);
    }
    void lerpSecond()
    {
        transform.position = new Vector3(transform.position.x, transform.parent.position.y + 1.02f, transform.position.z);
        transform.localScale = new Vector3(transform.localScale.x, 0.01f, transform.localScale.z);
        Vector3.Lerp(transform.localScale, scale, Time.deltaTime);

    }
}
