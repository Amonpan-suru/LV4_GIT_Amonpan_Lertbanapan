using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{

    // Start is called before the first frame update
    private Rigidbody rb;
    public int speed;
    private int score;
    public Text scoreText;
    public Text win;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        SetScoreText();

    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);
        rb.AddForce(movement*speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("item"))
        {
            other.gameObject.SetActive(false);
        }

        score += 1;
        SetScoreText();
    }

    void SetScoreText()
    {
        scoreText.text = ("Score: " + score.ToString());
        if (score >= 10)
        {
            win.text = ("You win!");
        }
    }
}
