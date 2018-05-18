using UnityEngine;
using System.Collections;

public class ShoeProperties : MonoBehaviour {
    public enum Property { left, right };

    public Property property;

    public ShoeController sc;

    public int id;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject == sc.shoe1)
        {
            sc.shoe2 = transform.gameObject;
            sc.Shoe2Property = property;
            sc.shoe2id = id;
        }
    }

}
