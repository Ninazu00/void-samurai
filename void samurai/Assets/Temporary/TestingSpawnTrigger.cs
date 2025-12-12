using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingSpawnTrigger : MonoBehaviour
{
    public Transform swords;
    public Transform[] spawnPoints;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player")
        {
            spriteRenderer.sprite = newSprite;
            foreach (Transform sp in spawnPoints)
            {
                float randomZ = Random.Range(-20f, 20f);
                Quaternion randomRotation = Quaternion.Euler(0, 0, randomZ);
                Instantiate(swords, sp.position, randomRotation);
            }
        }
    }
}
