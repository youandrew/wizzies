using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdcamera : MonoBehaviour
{
    Camera camObj;
    string state = "normal";
    public Transform target;


    [HideInInspector]
    float cameraDelay;

    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        camObj = gameObject.GetComponent<Camera>();
        offset = target.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * cameraDelay);

        transform.LookAt(target.position);
        //Input.GetAxis("Horizontal");
    }
}
