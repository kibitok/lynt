using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlNpcs : MonoBehaviour
{
    public GameObject gameObject;
    public float distance = 10f;
    public int gameObjectLimit  = 5; // Max amount of Prefabs
    public int gameObjectCount; // Number of Prefabs in the game at a time
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = new Vector3(Random.Range(-10.0f, 10.0f), 0, 0);
        //Vector3 Pos =transform.position + Random.onUnitSphere *distance;
        //Pos = new Vector3(Pos.x, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObjectCount < gameObjectLimit)
        
            //Instantiate(gameObject, transform.position + (new Vector3(1, 0, 0) * distance), transform.rotation);
        {
            // If the number of Prefabs in the game is less than the max number of Prefabs
            Instantiate(gameObject, pos, Quaternion.identity);
            // Create the prefab using a random position
            

            if (Input.GetKey(KeyCode.C))
            {
                Renderer rend = gameObject.GetComponent<Renderer>();
                rend.material.color = Color.green;

                Debug.Log(Color.green);
          
            }
            gameObjectCount++;
            Debug.Log(gameObject.transform.position);
            
        }
        
    }
         
        
    
    
}
