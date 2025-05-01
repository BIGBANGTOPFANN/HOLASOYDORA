using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WorkMenuControler : MonoBehaviour
{
    public TMP_Text intelligenceText;

    private PlayerStats playerStats;

    // Start is called before the first frame update
    void Start()
    {
         playerStats = FindAnyObjectByType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        intelligenceText.text = playerStats.intelligence.ToString();
    }

    public void ExitMenu()
    {
        gameObject.SetActive(false);
        FindAnyObjectByType<CharacterMovement1>().enabled = true;

        
    }

    public void TrainButton()
    {
        if (playerStats.timeLeft <= 0)
        {
            return;
        }

        playerStats.intelligence += 10;

        playerStats.timeLeft--;

        intelligenceText.text = playerStats.intelligence.ToString();

    }


}



