using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    private int trashes = 0;
    private int money = 0;
    [SerializeField]private Text TrashText;
    [SerializeField]private Text MoneyText;
    [SerializeField]private AudioSource CollectionSound;

    public int GetTrashes()
    {
        return trashes;
    }

    public int GetMoney()
    {
        return money;
    }

   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Trash"))
        {
            CollectionSound.Play();
            Destroy(collision.gameObject);
            money+= 800;
            trashes++;
            TrashText.text = "Trash = " + trashes + "/22";
            MoneyText.text = "Money = Rp " + money;
        }
    }
}