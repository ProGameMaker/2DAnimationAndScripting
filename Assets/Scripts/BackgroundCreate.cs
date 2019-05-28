using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCreate : MonoBehaviour
{
    public Vector2 startPoint;
    public Vector2 offSet;
    public Vector2 size;
    public GameObject candy;
    void Start() {

        for (int i = 0; i < size.y; i++)
        {
            for (int j = 0; j < size.x; j++) {
                Instantiate(candy,
                    new Vector2(startPoint.x + offSet.x*j,startPoint.y - offSet.y*i),
                    Quaternion.identity
                );             
                Debug.Log(startPoint.x + offSet.x*j);
                Debug.Log(startPoint.y - offSet.y*i);
            }
            
        }






    }




}
