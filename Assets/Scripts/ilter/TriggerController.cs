using UnityEngine;
using System.Collections;

public class TriggerController : MonoBehaviour {

    public GameController gc;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "GreenZone") gc.isAyranDrinkable = true;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "GreenZone") gc.isAyranDrinkable = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "GreenZone") gc.isAyranDrinkable = false;
    }
}
