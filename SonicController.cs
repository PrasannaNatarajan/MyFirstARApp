using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using Vuforia;


public class SonicController : MonoBehaviour {

	// Use this for initialization
    private Rigidbody rb;
	void Start () {
        rb = GetComponent<Rigidbody>();
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
	}
	
	// Update is called once per frame
	void Update () {
        float x = CrossPlatformInputManager.GetAxis("Horizontal");
        float y = CrossPlatformInputManager.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0, y);

        rb.velocity = movement * 4f;

        if (x != 0 && y != 0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x,Mathf.Atan2(x,y) * Mathf.Rad2Deg ,transform.eulerAngles.z);
        }

        
		
	}
}
