using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContractMenuControler : MonoBehaviour
{
    public TMP_Text firstStatText;

    public TMP_Text secondStatText;

    public TMP_Text thirdStatText;

    public int firstStatGoal = 150;

    public int secondStatGoal = 150;

    public int thirdStatGoal = 150;

    public GameObject winPopup;


    private PlayerStats playerStats;

    // Start is called before the first frame update
    void Start()
    {
         playerStats = FindAnyObjectByType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        firstStatText.text = playerStats.intelligence.ToString() + "/" + firstStatGoal.ToString();
        secondStatText.text = playerStats.intelligence.ToString() + "/" + firstStatGoal.ToString();
        thirdStatText.text = playerStats.intelligence.ToString() + "/" + firstStatGoal.ToString();

    }

    public void ExitMenu()
    {
        gameObject.SetActive(false);
        FindAnyObjectByType<CharacterMovement1>().enabled = true;

        
    }

    public void SignButton()
    {
        if (playerStats.strength >= firstStatGoal
            && playerStats.strength > secondStatGoal
        
            && playerStats.strength >= thirdStatGoal);
        {
            winPopup.SetActive(true);

        }


    }


}
