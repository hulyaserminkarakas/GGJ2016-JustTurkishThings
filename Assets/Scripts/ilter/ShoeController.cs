using UnityEngine;
using System.Collections;

public class ShoeController : MonoBehaviour {
    public Collider2D selectedObjectCollider;
    public GameObject shoe1;
    public GameObject shoe2;
    public ShoeProperties.Property Shoe2Property;


    public int shoe1id;
    public int shoe2id;

    public Vector3 MousePosition;

    public bool release;

    // Use this for initialization
    void Start () {
        ShoeProperties sp1 = shoe1.GetComponent<ShoeProperties>();
        shoe1id = sp1.id;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            selectedObjectCollider = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            if (selectedObjectCollider.gameObject.tag == "Shoe")
            {
                Debug.Log("Shoe selected.");

                shoe1 = selectedObjectCollider.gameObject;
                shoe1.transform.rotation = new Quaternion(0, 0, 0, 0);
                release = false;
                
            }
            else if (selectedObjectCollider.gameObject.tag == "Shoes")
            {
                shoe1 = selectedObjectCollider.gameObject;
                release = false;
            }
            ShoeProperties sp1 = shoe1.GetComponent<ShoeProperties>();
            shoe1id = sp1.id;
            ShoeProperties sp2 = shoe1.GetComponent<ShoeProperties>();
            shoe2id = sp2.id;
        }


        if(Input.GetMouseButtonUp(0))
        {
            release = true;
            shoe1 = null;
            shoe2 = null;
        }

        if (!release)
        {
            MousePosition = Input.mousePosition;
            MousePosition.z = 1f;
            shoe1.transform.position = Camera.main.ScreenToWorldPoint(MousePosition);
            Pair();
        }

        
    }

    void Pair()
    {
        if (shoe1id != shoe2id) return;
        shoe2.transform.rotation = new Quaternion(0, 0, 0, 0);
        if (Shoe2Property == ShoeProperties.Property.right) shoe2.transform.position = shoe1.transform.position + new Vector3(0.8f, 0, 0);
        else shoe2.transform.position = shoe1.transform.position + new Vector3(-0.8f, 0, 0);

        if (shoe1.tag != "Shoe") return;
        GameObject shoes = new GameObject("Shoes"+Mathf.Round(Random.Range(0,999)).ToString());
        
        shoe1.transform.parent = shoes.transform;
        shoe2.transform.parent = shoes.transform;
        shoe1.tag = "Shoes";
        shoe2.tag = "Shoes";
        shoes.tag = "Shoes";


        


    }
}
