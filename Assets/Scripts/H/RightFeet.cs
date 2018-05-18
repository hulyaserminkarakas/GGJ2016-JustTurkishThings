using UnityEngine;
using System.Collections;
using System;

public class RightFeet : MonoBehaviour {

	public Rigidbody2D rb;

	public bool check=false;

	public float distance;
	public bool paused;
	public bool gameover;

	public GameObject subline1;
	public GameObject subline2;
	public GameObject subline3;
	public GameObject subline4;
	public GameObject subline5;
	public GameObject subline6;
	public GameObject subline7;
	public GameObject subline8;
	public GameObject subline9;
	public GameObject subline10;
	public GameObject subline11;
	public GameObject subline12;
	public GameObject subline13;
	public GameObject subline14;
	public GameObject subline15;
	public GameObject subline16;
	public GameObject subline17;
	public GameObject subline18;
	public GameObject subline19;


 
	void Start() {

		rb = GetComponent<Rigidbody2D>();
	}

	void OnMouseDrag(){
		check = true;
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);

		transform.position = objPosition;
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "isTrigger") {

			gameover = true;
			//Application.Quit ();
		}
	}

	void OnMouseUp(){
		check = false;
	}

	void Update(){

		Physics2D.IgnoreLayerCollision(10,11,check==true);

	}
		
}
