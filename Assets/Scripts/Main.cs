using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Main : MonoBehaviour
{
    public int lives = 3;
    public int bricks = 20;
    public float resetDelay = 1f;
    public Text livesText;
    public GameObject Verloren;
    public GameObject Gewonnen;
    public GameObject Steine;
    public GameObject Paddle;
    public GameObject TodEffekt;
    public static Main instance = null;
    private GameObject KlonPaddle;

    // Start is called before the first frame update
    void Start() {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy (gameObject);

        Setup();
    }

    public void Setup() {
        KlonPaddle = Instantiate(Paddle, transform.position, Quaternion.identity) as GameObject;
        Instantiate(Steine, transform.position, Quaternion.identity);
    }

    void CheckGameOver() {

        if (bricks < 1) {
            Gewonnen.SetActive(true);
            Time.timeScale = .25f;
            Invoke ("Reset", resetDelay);
        }

        if (lives < 1) {
            Verloren.SetActive(true);
            Time.timeScale = .25f;
            Invoke ("Reset", resetDelay);
        }
    }

    void Reset() {
        Time.timeScale = 1f;
        Application.LoadLevel(Application.loadedLevel);
    }

    // Update is called once per frame
    public void LoseLife() {
        lives--;
        livesText.text = "" + lives;
        Instantiate(TodEffekt, KlonPaddle.transform.position, Quaternion.identity);
        Destroy(KlonPaddle);
        Invoke ("SetupPaddle", resetDelay);
        CheckGameOver();
    }

    void SetupPaddle() {
        KlonPaddle = Instantiate(Paddle, transform.position, Quaternion.identity) as GameObject;
    }

    public void DestroyBrick() {
        bricks--;
        CheckGameOver();
    }
}
