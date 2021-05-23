using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    //FoodPrefab
    public GameObject FoodPrefab;

    //Border Positions
    public Transform TopBorder;
    public Transform BottomBorder;
    public Transform LeftBorder;
    public Transform RightBorder;

    void Spawn()
    {
        // position between left & right border
        int x = (int)Random.Range(LeftBorder.position.x,RightBorder.position.x);
        
        // position between top & bottom border
        int y = (int)Random.Range(BottomBorder.position.y, TopBorder.position.y);
    
        //Instantiate the foot at (x,y)
        Instantiate(FoodPrefab, new Vector2(x,y),Quaternion.identity);
    }


    void Start()
    {
        //Spawn food every 4 seconds, starting 2 seconds after the game starts
        InvokeRepeating("Spawn", 2,4);
    }

   
}
