using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Balloon : MonoBehaviour
{

    public float upSpeed;
    int score = 0;

    AudioSource audioSource;

    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y  > 7f)
        {
            SceneManager.LoadScene("Game");
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(0, upSpeed, 0);
    }

    private void OnMouseDown()
    {
        score++;
        scoreText.text = score.ToString();

        audioSource.Play();

        ResetPosition();
    }

    private void ResetPosition()
    {
        float randomX = Random.Range(-7.35f, 7.5f);

        transform.position = new Vector2(randomX, -7f);
    }
}
