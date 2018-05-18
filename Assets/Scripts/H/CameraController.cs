using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public float speed;

	void Start(){
	
	}

	void Update(){
		
	transform.position += new Vector3 (0, Time.deltaTime * speed, 0);

	}
}
