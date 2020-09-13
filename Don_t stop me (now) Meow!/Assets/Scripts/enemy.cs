using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public int hp;
    public float speed = 15;

    private float cooldown;
    public float startshoottime =2;

    public GameObject projectile;

    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        hp = 2;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        cooldown = startshoottime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, speed * Time.deltaTime);
        if (transform.position.z > 2f)
        {
            die();
        }

        if (cooldown <=0){
            Instantiate(projectile, transform.position, Quaternion.identity);
            cooldown = startshoottime;
        }else{
            cooldown -=Time.deltaTime;
        }

        
        if(hp <= 0){
            hp=0;
            die();
        }
    }

    void die(){
        Destroy(this.gameObject);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Bullet")
        {
            Destroy(col.gameObject);
            hp -= 1;
        }
    }

}
