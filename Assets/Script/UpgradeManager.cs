using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{

    private float unlockCost, upgradeCost, Output;
    public Button lv1, lv2, lv3, lv4;
    public Sprite tombolKuning, tombolPutih, tombolHijau;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.level == 1 && GameManager.achievementLevel < 4)
        {
            if (GameManager.gold > GameManager.upgradeLevelPrice )
            {

                lv1.interactable = true;
                Image baru = lv1.GetComponent<Image>();
                baru.sprite = tombolKuning;
            }
            else
            {
                
                    Image baru = lv1.GetComponent<Image>();
                    baru.sprite = tombolPutih;
                    lv1.interactable = false;
                
                
            }
        }

        if (GameManager.level == 2 && GameManager.achievementLevel < 4)
        {
            if (GameManager.gold > GameManager.upgradeLevelPrice)
            {

                lv2.interactable = true;
                Image baru = lv2.GetComponent<Image>();
                baru.sprite = tombolKuning;
            }
            else
            {
                    Image baru = lv2.GetComponent<Image>();
                    baru.sprite = tombolPutih;
                    lv2.interactable = false;

            }
        }

        if (GameManager.level == 3 && GameManager.achievementLevel < 4)
        {
            if (GameManager.gold > GameManager.upgradeLevelPrice)
            {

                lv3.interactable = true;
                Image baru = lv3.GetComponent<Image>();
                baru.sprite = tombolKuning;
            }
            else
            {
                Image baru = lv3.GetComponent<Image>();
                baru.sprite = tombolPutih;
                lv3.interactable = false;

            }
        }

        if (GameManager.level == 4 && GameManager.achievementLevel < 4)
        {
            if (GameManager.gold > GameManager.upgradeLevelPrice)
            {

                lv4.interactable = true;
                Image baru = lv4.GetComponent<Image>();
                baru.sprite = tombolKuning;
            }
            else
            {
                Image baru = lv4.GetComponent<Image>();
                baru.sprite = tombolPutih;
                lv4.interactable = false;

            }
        }


    }

    public void Level1()
    {
        

        if (GameManager.level == 1 && (GameManager.achievementLevel < 4 && GameManager.achievementLevel > 0))
        {
            GameManager.achievementLevel += 1f;
            GameManager.collectPerSecond += 0.2f;
            GameManager.collectPerTap = 0.2f;
            upgradeCost = 1;
            unlockCost = 1;
            GameManager.upgradeLevelPrice = upgradeCost;

            GameManager.gold -= upgradeCost;

        }


        if (GameManager.level == 1 && GameManager.achievementLevel == 4)
        {
            GameManager.achievementLevel += 1f;
            GameManager.collectPerSecond += 0.2f;
            GameManager.collectPerTap = 2f;
            upgradeCost = 100;
            unlockCost = 1;

            GameManager.achievementLevel = 1;
            lv1.interactable = false;
            lv2.gameObject.SetActive(true);
            GameManager.level = 2;
            GameManager.upgradeLevelPrice = upgradeCost;


            Image baru = lv1.GetComponent<Image>();
            baru.sprite = tombolPutih;
            lv1.interactable = false;


        }

        if (GameManager.level == 1 && GameManager.achievementLevel == 0)
        {
            GameManager.achievementLevel += 1f;
            GameManager.collectPerSecond += 0.2f;
            GameManager.collectPerTap = 0.2f;
            upgradeCost = 1;
            unlockCost = 1;
            GameManager.upgradeLevelPrice = upgradeCost;

        }
    }

    public void Level2()
    {

        if (GameManager.level == 2 && GameManager.achievementLevel < 4)
        {
            GameManager.achievementLevel += 1f;
            GameManager.collectPerSecond += 2f;
            GameManager.collectPerTap += 2;
            upgradeCost = 100;
            unlockCost = 100;
            GameManager.upgradeLevelPrice = upgradeCost;

            GameManager.gold -= upgradeCost;

        }


        if (GameManager.level == 2 && GameManager.achievementLevel == 4)
        {
            GameManager.achievementLevel += 1f;
            GameManager.collectPerSecond += 2f;
            GameManager.collectPerTap += 2;
            upgradeCost = 1000;
            unlockCost = 100;

            GameManager.achievementLevel = 1;
            lv2.interactable = false;
            lv3.gameObject.SetActive(true);
            GameManager.level = 3;
            GameManager.upgradeLevelPrice = upgradeCost;


            Image baru = lv2.GetComponent<Image>();
            baru.sprite = tombolPutih;
            lv2.interactable = false;


        }

    }

    public void Level3()
    {
        if (GameManager.level == 3 && GameManager.achievementLevel < 4)
        {
            GameManager.achievementLevel += 1f;
            GameManager.collectPerSecond += 20f;
            GameManager.collectPerTap += 20;
            upgradeCost = 1000;
            unlockCost = 1000;
            GameManager.upgradeLevelPrice = upgradeCost;


            GameManager.gold -= upgradeCost;

        }


        if (GameManager.level == 3 && GameManager.achievementLevel == 4)
        {
            GameManager.achievementLevel += 1f;
            GameManager.collectPerSecond += 20f;
            GameManager.collectPerTap += 20;
            upgradeCost = 1000000;
            unlockCost = 1000;

            GameManager.achievementLevel = 1;
            lv3.interactable = false;
            lv4.gameObject.SetActive(true);
            GameManager.level = 4;
            GameManager.upgradeLevelPrice = upgradeCost;

            Image baru = lv3.GetComponent<Image>();
            baru.sprite = tombolPutih;
            lv3.interactable = false;


        }


    }

    public void Level4()
    {
        if (GameManager.level == 4 && GameManager.achievementLevel < 4)
        {
            GameManager.achievementLevel += 1f;
            GameManager.collectPerSecond += 200f;
            GameManager.collectPerTap += 200;
            upgradeCost = 1000000;
            unlockCost = 1000000;
            GameManager.upgradeLevelPrice = upgradeCost;

            GameManager.gold -= upgradeCost;

        }

        if (GameManager.level == 4 && GameManager.achievementLevel == 4)
        {
            GameManager.achievementLevel += 1f;
            GameManager.collectPerSecond += 200f;
            GameManager.collectPerTap += 200;
            upgradeCost = 1000000;
            GameManager.upgradeLevelPrice = upgradeCost;
            unlockCost = 1000000;

            GameManager.achievementLevel = 1;
            lv4.interactable = false;

            GameManager.level = 5;
            Image baru = lv4.GetComponent<Image>();
            baru.sprite = tombolPutih;
            lv4.interactable = false;

        }

    }
}
