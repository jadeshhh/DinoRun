using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanagerscript : MonoBehaviour
{
    public int score;
    public int lives;
    public GameObject waterPrefab;
    public Vector3[] wat;

    public Vector3[] spikepos;
    public GameObject spikes;
    
    public Vector3[] sawpos;
    public GameObject sawPrefab;
    // Start is called before the first frame update

    public GameObject suPrefab;
    public Vector3[] spikeup;
    public bool gameState;

    public Vector3[] enempos;
    public GameObject enemPrefab;
    void Start()
    {
        
        lives = 5;

        for(int i = 0; i < spikepos.Length; i++){
            Instantiate(spikes, spikepos[i], Quaternion.identity);
        }
        for(int i = 0; i < wat.Length; i++){
            Instantiate(waterPrefab, wat[i], Quaternion.identity);
        }
        for(int i = 0; i < sawpos.Length; i++){
            Instantiate(sawPrefab, sawpos[i], Quaternion.identity);
        }
        for(int i = 0; i < spikeup.Length; i++){
            Instantiate(suPrefab, spikeup[i], Quaternion.identity);
        }
        for(int i = 0; i < enempos.Length; i++){
            Instantiate(enemPrefab, enempos[i], Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(lives <= 0){
            gameState = false;
        }
        if(!gameState){
            Debug.Log("You lost!");
        }
    }
}
