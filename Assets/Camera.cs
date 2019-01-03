using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public Camera cam;
    public float y;
	// Use this for initialization
	void Start () {
        cam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        cam.transform.rotation.Set(0,100,0,0);
        cam.transform.position = new Vector3 { x = (float)(cam.transform.position.x - 0.001), y = cam.transform.position.y, z = (float)(cam.transform.position.z+0.001)};
        //cam.transform.rotation = new UnityEngine.Quaternion { x = 0, y = (float)(cam.transform.rotation.y),z = 0 };
    }
}
