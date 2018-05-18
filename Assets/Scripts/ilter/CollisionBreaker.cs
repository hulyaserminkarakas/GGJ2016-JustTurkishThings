using UnityEngine;
using System.Collections;

public class CollisionBreaker : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "Shoes")
        {
            PolygonCollider2D col = other.gameObject.GetComponent<PolygonCollider2D>();
            col.enabled = false;
        }
    }
}
