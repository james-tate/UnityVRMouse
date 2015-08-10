using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mouse : MonoBehaviour {

    /// <summary>
    /// Keeps the mouse oriented correctly for movement
    /// </summary>
    public GameObject CenterEyeAnchor;

    /// <summary>
    /// Resets the position of the mouse if it goes off screen
    /// </summary>
    public GameObject resetPos;

    /// <summary>
    /// Mouse speed movement
    /// </summary>
    public float speed = 1;

    /// <summary>
    /// The mouse gameobject
    /// </summary>
    public GameObject mouseObject;

    /// <summary>
    /// The distance of the ray from the mouse 
    /// </summary>
    public float rayDistance = 10f;

    /// <summary>
    /// Print the name of the ray target
    /// </summary>
    public Text name;


    void FixedUpdate()
    {
        //Controls the movement of the mouse
        float h = speed * Input.GetAxis("Mouse X") * Time.deltaTime;
        float v = speed * Input.GetAxis("Mouse Y") * Time.deltaTime;
        mouseObject.transform.Translate(h, v, 0f, CenterEyeAnchor.transform);
        if (Input.GetKeyDown(KeyCode.C))
        {
            mouseObject.transform.position = resetPos.transform.position;
        }

        //Controls the ray interception of the mouse
        mouseObject.transform.LookAt(CenterEyeAnchor.transform);
        RaycastHit target;
        Ray targetRay = new Ray(mouseObject.transform.position, -mouseObject.transform.forward);
        if (Physics.Raycast(targetRay, out target, rayDistance)){
            //do something here for now just print the name
            //print(target.transform.name);
            name.text = target.transform.name;
        }

    }
}
