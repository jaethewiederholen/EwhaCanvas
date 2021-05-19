using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

[RequireComponent(typeof(ARRaycastManager))]
public class TouchImageTarget : MonoBehaviour
{
    private ARRaycastManager arRaycastManager;

    [SerializeField]
    private Camera arCamera;

    private static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    //public GameObject myPrefab;
    // Start is called before the first frame update

    private Vector2 touchPosition = default;

    void Awake()
    {
        arRaycastManager = GetComponent<ARRaycastManager>(); 
    }

    void Start()
    {
        
    }

    public void newObject(string objName)

    {
        Instantiate(Resources.Load("Prefabs/" + objName), new Vector3(0, 0, 0), Quaternion.identity);
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            touchPosition = touch.position;

            if (arRaycastManager.Raycast(touchPosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.Image)) //if you touch the Ar tracked image
            {

                string currentScene = SceneManager.GetActiveScene().name; //find the current scene and intantiate proper prefab
                switch (currentScene)
                {
                    case "LARGE":
                        newObject("Dae_ClearCanvas");
                        break;
                    case "MIDDLE":
                        newObject("Joong_ClearCanvas");
                        break;
                    case "ECC":
                        newObject("ECC_ClearCanvas");
                        break;
                    case "POSCO":
                        newObject("Posco_ClearCanvas");
                         break;
                    case "GSM":
                        newObject("GSM_ClearCanvas");
                         break;
                    case "LIBRARY":
                        newObject("Lib_ClearCanvas");
                         break;
                    case "MUSEUM":
                        newObject("Museum_ClearCanvas");
                        break;
                }
            }
        }
    }
}
