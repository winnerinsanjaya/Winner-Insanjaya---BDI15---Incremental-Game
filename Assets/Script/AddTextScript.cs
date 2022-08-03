using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddTextScript : MonoBehaviour
{

    public float menghilangTime = 0.5f;
    public Vector2 speed;
    // Start is called before the first frame update
    void Start()
    {

       Text txt = gameObject.GetComponent<Text>();
        txt.text = GameManager.collectPerTap.ToString();

       transform.localPosition = new Vector3(Random.Range(-40, 30), Random.Range(-30, 40), 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime);
        menghilangTime -= Time.deltaTime;
        if(menghilangTime < 0)
        {
            Destroy(gameObject);
        }
    }
}
