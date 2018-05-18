using UnityEngine;
using System.Collections;

public class ShoeController2 : MonoBehaviour {


    private Vector3 screenPoint;
    private Vector3 offset;
    private float _lockedYPosition;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        //screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position); // I removed this line to prevent centring 
        _lockedYPosition = screenPoint.y;
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        curPosition.x = _lockedYPosition;
        transform.position = curPosition;
    }
}
