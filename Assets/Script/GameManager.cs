using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private float _collectSecond;

    
    public static float collectPerSecond, gold, collectPerTap, level, achievementLevel;

    public Text goldText, autoCollectText;

    public Transform areaAddText;
    public GameObject addText;

    public static float upgradeLevelPrice, upgradeResPrice;

    // Start is called before the first frame update
    void Start()
    {
        level = 1;
        collectPerSecond = 0;
        achievementLevel = 0f; 
        collectPerTap = 0.2f;

    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(level + " AL " + achievementLevel);

        _collectSecond += Time.unscaledDeltaTime;

        if (_collectSecond >= 1f)

        {

            CollectPerSecond();

            _collectSecond = 0f;

        }


        //////////////////////
        goldText.text = "Gold : " + gold.ToString();
        autoCollectText.text = "auto collect : " + collectPerSecond.ToString() + " /second";
    }

    public void CollectPerSecond()
    {
        gold += collectPerSecond;
    }

    public void AddGold()
    {
        
        gold += collectPerTap;

        //var position = new Vector3(Random.Range(-6,-4), Random.Range(1, 3), 0);
        //Instantiate(addText, position, Quaternion.identity, areaAddText);
        Instantiate(addText, areaAddText);

    }
}
