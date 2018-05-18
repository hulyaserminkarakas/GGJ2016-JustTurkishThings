using UnityEngine;
using System.Collections;

public class MouseDrag : MonoBehaviour {

	public float distance = 10F; 
	public float hand1;
	public float hand2;
	public float hand3;
	public float hand4;

	public float z;

	public Sprite kolonya1;
	public Sprite kolonya2;
	public Sprite woman2;
	public Sprite woman3;
	public Sprite child2;
	public Sprite child3;
	public Sprite man2;
	public Sprite man3;

	public SpriteRenderer sr;
	public SpriteRenderer sr1;
	public SpriteRenderer sr2;
	public SpriteRenderer sr3;

	public GameObject text;


	void Start(){

		StartCoroutine (Up());
	}
		
	void OnMouseDrag(){

		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);

		transform.position = objPosition;
	}

	IEnumerator Up() {
		sr.sprite = kolonya1;
		yield return new WaitForSeconds(0.2F);
		StartCoroutine (Down());
	}

	IEnumerator Down() {
		sr.sprite = kolonya2;
		yield return new WaitForSeconds(0.2F);
		StartCoroutine (Up());
	}


	void Update(){
		z=transform.position.z;
		z = -1F;

		if (hand1 >= 4 && hand2 >= 4 && hand3 >= 4) {
			text.SetActive (true);
		}

		else { 

			if(transform.position.x > -44.0F && transform.position.x <  -19.0F){
				hand1 += Time.deltaTime;

				if (hand1 >= 2 && hand1 <= 4) {
					sr1.sprite = woman2;
				}
				else if (hand1 >= 4) {
					sr1.sprite = woman3;
				}

			}
			else if(transform.position.x > -3.0F && transform.position.x < 23.0F){
			
				if (transform.position.y > 13.0F) {
					hand2 += Time.deltaTime * 3;
				
					if (hand2 >= 2 && hand2 <= 4) {
						sr2.sprite = child2;
					} else if (hand2 >= 4) {
						sr2.sprite = child3;
					}
				}
				else if (transform.position.y < 13.0F) {
					hand2 += Time.deltaTime;
						if (hand2 >= 2 && hand2 <= 4) {
							sr2.sprite = child2;
						} 
						else if(hand2 >= 4) {
							sr2.sprite = child3;
						}
					}
			
				}


			else if(transform.position.x > 45.0F && transform.position.x < 65.0F){
				hand3 += Time.deltaTime;
				if (hand3 >= 2 && hand3 <= 4) {
					sr3.sprite = man2;
				}
				else if (hand3 >= 4) {
					sr3.sprite = man3;
				}
			}

		}
	}
}
