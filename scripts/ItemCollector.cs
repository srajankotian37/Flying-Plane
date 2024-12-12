using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private int coin = 0;
    [SerializeField] private Text coinText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("coin"))
        {
            Destroy(collision.gameObject);
            coin++;
            coinText.text = $"{coin}";
        }
    }

    private void OnDestroy()
    {
        // Save the score when the game ends
        PlayerPrefs.SetInt("Score", coin);
        PlayerPrefs.Save();
    }
}
