using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitterHelperSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject MonsterPic;
    [SerializeField]
    private GameObject WaterPic;
    [SerializeField]
    private GameObject CandyPic;
    [SerializeField]
    private GameObject WitnerPic;

    [SerializeField]
    private GameObject MonsterText;
    [SerializeField]
    private GameObject PowerUpText;

    public void SetHelp()
    {
        int randNum = Random.Range(0, 2);
        if(randNum == 0)
        {
            string pos = GetComponent<SpawnScripts>().GetMonsterPosition();
            PicActivate(pos);
            MonsterText.SetActive(true);
        }
        else
        {
            string pos = GetComponent<SpawnScripts>().GetPowerUpPosition();
            PicActivate(pos);
            PowerUpText.SetActive(true);
        }
    }

    void PicActivate(string positionString)
    {
        switch (positionString)
        {
            case "Monster":
                MonsterPic.SetActive(true);
                Debug.Log("Activated monster pic");
                break;
            case "Water":
                WaterPic.SetActive(true);
                Debug.Log("Activated water pic");
                break;
            case "Candy":
                CandyPic.SetActive(true);
                Debug.Log("Activated candy pic");
                break;
            case "Winter":
                WitnerPic.SetActive(true);
                Debug.Log("Activated winter pic");
                break;
            default:
                Debug.Log(positionString + " Error with the SpitterHelperSystem script. (check switch case)");
                break;
        }
    }
}
