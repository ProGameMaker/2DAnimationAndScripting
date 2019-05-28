using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Candy : MonoBehaviour
{
    public Sprite[] SpriteList;
    public Sprite[] ConSpriteList;
    // Start is called before the first frame update
    public float maxChangeTime = 2f;
    float time = 2;
    int i;
    float changeTime;
    void Awake() {
        i = Random.Range(0,SpriteList.Length);
        changeTime = Random.RandomRange(0f,maxChangeTime);
        GetComponent<SpriteRenderer>().sprite = SpriteList[i];
    }



    void Start()
    {
        time = changeTime;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time > 0) {
            GetComponent<SpriteRenderer>().sprite = SpriteList[i];
        }
        else {
            GetComponent<SpriteRenderer>().sprite = ConSpriteList[i];
        }

        if (time < -2* changeTime) time = changeTime;


        
    }
}
