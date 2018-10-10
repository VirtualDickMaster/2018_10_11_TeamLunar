using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class OnlyOneCameraMain : MonoBehaviour {

	void Awake () {
        if (Camera.allCameras.Length>0 && Camera.main != this.GetComponent<Camera>()) {
            Destroy(this.gameObject);
        }
	}
	
}
