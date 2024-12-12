using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bird : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.Space))
        {
            rb.velocity = Vector2.up * speed;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("obs"))
        {
            // Reset the score when the bird crashes
            PlayerPrefs.SetInt("Score", 0);
            PlayerPrefs.Save();
            SceneManager.LoadScene(0); // Reload the start menu scene
        }
    }
}
