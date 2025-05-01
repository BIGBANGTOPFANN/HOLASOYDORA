using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EatingMenuController : MonoBehaviour
{
    public TMP_Text strengthText;

    private PlayerStats playerStats;

    // Start is called before the first frame update
    void Start()
    {
         playerStats = FindAnyObjectByType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        strengthText.text = playerStats.strength.ToString();
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
        playerStats.strength += 10;

        playerStats.timeLeft--;

        strengthText.text = playerStats.strength.ToString();

    }


}



