using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class RayCastManager : MonoBehaviour
{

    public ARRaycastManager raycastManager;
    public Camera arCamera;
    private GameObject spwanObject;
    public GameObject objects;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    public ARPlaneManager ArPlane;
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;
    public GameObject selectionPanel;
    public GameObject pasueButton;
    public GameObject retryObject;
    public ARSessionOrigin Arsession;
    Pose hitpos;
    bool planeCheck = true;
    // Start is called before the first frame update
    void Start()
    {
      //  ArPlane = GetComponent<ARPlaneManager>();
       // Arsession = GetComponent<ARSessionOrigin>();
    }

    // Update is called once per frame
    void Update()
    {
        if (planeCheck == true)
        {

            Ray ray = arCamera.ScreenPointToRay(Input.mousePosition);

            if (Input.GetMouseButton(0))
            {
               
                if (raycastManager.Raycast(ray, hits, TrackableType.Planes))
                {

                    SpwanObject();
                    planeCheck = false;
                }
            }
        }
    }

    public void SpwanObject()
    {
        hitpos = hits[0].pose;
        if (spwanObject == null)
        {

            spwanObject = Instantiate(objects, hitpos.position, hitpos.rotation);
            foreach (var plane in ArPlane.trackables)
            {
                plane.gameObject.SetActive(false);

                Debug.Log("showing");
                ArPlane.enabled = false;
            }

            //ArPlane.enabled = false;
          //  ArPlane.GetComponent<ARPlaneManager>().enabled = false;
            
            //   spwanObject.transform.rotation = Quaternion.Euler(0f, -180f, 0f);
            //  ArPlane.enabled = false;
        }
       
    }
    public void level1button()
    {
        selectionPanel.SetActive(false);
        level1.SetActive(true);
        pasueButton.SetActive(true);
        retryObject.SetActive(true);
    }
    public void level2button()
    {
        selectionPanel.SetActive(false);
        level2.SetActive(true);
        pasueButton.SetActive(true);
        retryObject.SetActive(true);
    }
    public void level3button()
    {
        selectionPanel.SetActive(false);
        level3.SetActive(true);
        pasueButton.SetActive(true);
        retryObject.SetActive(true);
    }
    public void level4button()
    {
        selectionPanel.SetActive(false);
        level4.SetActive(true);
        pasueButton.SetActive(true);
        retryObject.SetActive(true);
    }
    public void level5button()
    {
        selectionPanel.SetActive(false);
        level5.SetActive(true);
        pasueButton.SetActive(true);
        retryObject.SetActive(true);
    }
}
