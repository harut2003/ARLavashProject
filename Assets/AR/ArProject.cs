using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ArProject : MonoBehaviour
{
    ARRaycastManager _arRaycastManager;
    Vector3 mousePos;

    public GameObject prefab;
    bool t = true;

    List<ARRaycastHit> hits = new List<ARRaycastHit>();

    // Start is called before the first frame update
    void Start()
    {
        _arRaycastManager = GetComponent<ARRaycastManager>();
    }
    void call(bool n)
    {

    }

    
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0)  && t)
		{
            mousePos = Input.mousePosition;
            _arRaycastManager.Raycast(mousePos, hits);
            
            if (hits.Count>0 )
			{
                UIGame.isFirst = true;
                var cameraForward = Camera.main.transform.forward;
                var cameraVector = new Vector3(cameraForward.x, 0, cameraForward.z).normalized;
                prefab.transform.position = hits[0].pose.position;
                prefab.transform.rotation = Quaternion.LookRotation(cameraVector);
                prefab.SetActive(true);
                //go.transform.localScale = new Vector3(0.5f, 0.5f,0.5f);
                t = false;
                GameObject.Find("Trackables").SetActive(false);
            }
        }
        
    }
}
