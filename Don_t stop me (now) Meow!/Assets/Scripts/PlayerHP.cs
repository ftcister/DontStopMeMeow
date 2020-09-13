using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{

    public int hp;
    public int numberofhp;

    public Image[] kittens;
    public Sprite fullkitten;
    public Sprite emptykitten;

    public GameObject GameOver;
    // Start is called before the first frame update
    void Start()
    {
        hp=3;
    }

    // Update is called once per frame
    void Update()
    {

        if (hp > numberofhp){
            hp = numberofhp;
        }

        for( int i = 0; i < kittens.Length; i++){
            if (i < hp){
                kittens[i].sprite = fullkitten;
            }else{
                kittens[i].sprite = emptykitten;
            }

            if (i < numberofhp){
                kittens[i].enabled = true;
            }else{
                kittens[i].enabled = false;
            } 
        }
    }

    void OnTriggerEnter(Collider col){
        if (col.tag == "bullet enemy"){
            Destroy(col.gameObject);
            hp -= 1;
        }
    }
  
}
