using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SleepMenuControler : MonoBehaviour
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

        strengthText.text = playerStats.timeLeft.ToString();






    }

    public void ExitMenu()
    {
        gameObject.SetActive(false);
        FindAnyObjectByType<CharacterMovement1>().enabled = true;

        
    }

    public void TrainButton()
    {
        

        playerStats.timeLeft = 10;

        strengthText.text = playerStats.timeLeft.ToString();

    }


}



