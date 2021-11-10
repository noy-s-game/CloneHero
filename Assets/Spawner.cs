using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject blueNote,greenNote,orangeNote,redNote,yellowNote;    
    public float lowerSpawnLimit = 1f;
    public float upperSpawnLimit = 2f;
    float nextSpawn = 0f;
    int noteToSpawn;

    Vector2 spawnPos;      
    void Update()
    {
        if (Time.time > nextSpawn) {
            noteToSpawn = Random.Range(1, 6);
            switch (noteToSpawn) {
                case 1:
                    Instantiate(greenNote, new Vector2(-9.585507f,transform.position.y), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(redNote, new Vector2(-5.585508f, transform.position.y), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(yellowNote, new Vector2(-1.414492f, transform.position.y), Quaternion.identity);
                    break;
                case 4:
                    Instantiate(blueNote, new Vector2(2.414493f, transform.position.y), Quaternion.identity);
                    break;
                case 5:
                    Instantiate(orangeNote, new Vector2(6.414493f, transform.position.y), Quaternion.identity);
                    break;
            }    
            nextSpawn = Time.time + Random.Range(lowerSpawnLimit, upperSpawnLimit);
        }
    }  
}
