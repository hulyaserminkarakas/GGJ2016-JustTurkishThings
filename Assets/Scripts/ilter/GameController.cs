using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public GameObject doner;
    public GameObject ayran;
    public float amountOfConsumables = 100;
    public float amountOfDoner;
    public float amountOfAyran;
    public float consumeAmount = 20f;
    public float score;
    public Text scoreText;
    public Button restart;
    public float amountOfAyranScale = 0;
    public float amountOfDonerScale = 0;

    public bool isAyranDrinkable = false;

    public float chewingTime;

    public BalanceController bc;
    public bool gameOver = false;

    public SpriteRenderer ayranRenderer;
    public Sprite ayran0;
    public Sprite ayran1;
    public Sprite ayran2;
    public Sprite ayran3;
    public Sprite ayran4;

    public SpriteRenderer donerRenderer;
    public Sprite doner0;
    public Sprite doner1;
    public Sprite doner2;
    public Sprite doner3;
    public Sprite doner4;

    // Use this for initialization
    void Start () {
        amountOfAyran = amountOfConsumables;
        amountOfDoner = amountOfConsumables;
        score = 0;
        scoreText.text = score.ToString();
        
        InvokeRepeating("Consume", 1, chewingTime);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (amountOfAyran > 0 && amountOfDoner > 0)
        {
            UpdateScale();
            
            scoreText.text = score.ToString();
        }
        else
        {
            restart.gameObject.SetActive(true);
            CancelInvoke("Consume");
            gameOver = true;
            UpdateScale();
        }
    }

    void UpdateScale()
    {
        amountOfAyranScale = Mathf.Round((amountOfAyran) / consumeAmount);
        amountOfDonerScale = Mathf.Round((amountOfDoner) / consumeAmount);

        switch ((int)amountOfAyranScale)
        {
            case 4:
                ayranRenderer.sprite = ayran4;
                break;

            case 3:
                ayranRenderer.sprite = ayran3;
                break;

            case 2:
                ayranRenderer.sprite = ayran2;
                break;

            case 1:
                ayranRenderer.sprite = ayran1;
                break;

            case 0:
                ayranRenderer.sprite = ayran0;
                break;
            default:
                break;
        }

        switch ((int)amountOfDonerScale)
        {
            case 4:
                donerRenderer.sprite = doner4;
                break;

            case 3:
                donerRenderer.sprite = doner3;
                break;

            case 2:
                donerRenderer.sprite = doner2;
                break;

            case 1:
                donerRenderer.sprite = doner1;
                break;

            case 0:
                donerRenderer.sprite = doner0;
                break;
            default:
                break;
        }
    }

    void Consume()
    {
        for (int i = 0; i < chewingTime; i++) ;
        amountOfDoner -= consumeAmount;
        if (isAyranDrinkable)
        {
            amountOfAyran -= consumeAmount;
            score += Time.deltaTime;
            bc.GreenZone.transform.localScale -= new Vector3(Random.Range(0.01F, 0.25F), 0, 0);
            bc.GreenZone.transform.position += new Vector3(Random.Range(-1F, 1F), 0, 0);

        }


    }

    public void Restart()
    {
        SceneManager.LoadScene("1", LoadSceneMode.Single);
    }
}
