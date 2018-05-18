using UnityEngine;
using System.Collections;

public class BalanceController : MonoBehaviour {
    public GameObject RedZone;
    public GameObject GreenZone;
    public GameObject Cursor;
    public Rigidbody2D rb;
    public float speed;
    public GameController gc;

	// Use this for initialization
	void Awake () {
        GreenZone.transform.position = RedZone.transform.position;
        Cursor.transform.position = RedZone.transform.position;
    }

    void Start()
    {
        GreenZone.transform.position += new Vector3(Random.Range(0,11.5f),0,0);
        Cursor.transform.position = GreenZone.transform.position;
        Cursor.transform.position += new Vector3(Random.Range(0, 3.89f), 0, 0);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (!gc.gameOver)
        {        //GreenZone.transform. -= new Vector3(0.1f, 0, 0);
            if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WSAPlayerX86 || Application.platform == RuntimePlatform.WSAPlayerX64)
            {
                float moveHorizontal = Input.GetAxis("Horizontal");
                Vector3 movement = new Vector3(Mathf.Round(moveHorizontal), 0, 0);
                rb.AddForce(movement * speed);
            }
            else if (Application.platform == RuntimePlatform.WSAPlayerARM || Application.platform == RuntimePlatform.WSAPlayerX86 || Application.platform == RuntimePlatform.WSAPlayerX64 || Application.platform == RuntimePlatform.WP8Player || Application.platform == RuntimePlatform.Android)
            {
                float moveHorizontal = Input.acceleration.x;
                Vector3 movement = new Vector3(moveHorizontal, 0, 0);
                rb.AddForce(movement * speed);
            }
        }

            
    }
}
