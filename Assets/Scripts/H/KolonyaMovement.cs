using UnityEngine;
using System.Collections;

public class KolonyaMovement : MonoBehaviour {

	public float hand1=0;
	public float hand2=0;
	public float hand3=0;
	public float hand4=0;

//	public float randomPos;
	// Use this for initialization
	void Start () {
		//StartCoroutine(Move1());
	//	transform.rotation = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public enum MouseOverType{ Action1, Action2, Action3, Action4 /*, ...*/ }
	public MouseOverType mouseOverType;

	//public GameObject cube;

	/*
	void OnMouseOver()
	{        
		switch(mouseOverType)
		{
		case MouseOverType.Action1:
			hand1 += Time.deltaTime; break;
		case MouseOverType.Action2 : 
			hand2 += Time.deltaTime; break;
		case MouseOverType.Action3 : 
			hand3 += Time.deltaTime; break; break;
		case MouseOverType.Action4 : 
			hand4 += Time.deltaTime; break; break;
		}    
	}

	IEnumerator Move1() {
		if(transform.position.x < -7) {
			randomPos += 1;
		}
		else if(transform.position.x > 7){
			randomPos -= 1;
		}
		else{
			randomPos = Random.Range (-1.5F, 1.5F);
		}
		yield return new WaitForSeconds(0.05F);
		StartCoroutine (Move2());
	}

	IEnumerator Move2() {
		if(transform.position.x < -7) {
			randomPos += 1;
		}
		else if(transform.position.x > 7){
			randomPos -= 1;
		}
		else{
			randomPos = Random.Range (-1.5F, 1.5F);
		}
	
		transform.position += new Vector3(randomPos,0,0);
		yield return new WaitForSeconds(0.05F);
		StartCoroutine (Move1());
	}
	*/
}
