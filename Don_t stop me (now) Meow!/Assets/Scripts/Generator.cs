using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{

    public GameObject theEnemy;
    public float xpos;
    public float ypos;
    public float zpos;
    public int enemycount;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }
    IEnumerator EnemyDrop()
    {
        while (true)
        {
            xpos = Random.Range(-4.5f, 4.5f);
            ypos = Random.Range(0.5f, 5.5f);
            zpos = -150f;
            Instantiate(theEnemy, new Vector3(xpos, ypos, zpos), Quaternion.identity);
            yield return new WaitForSeconds(2);
            enemycount += 1;
        }
    }
    // Update is called once per frame
    void Update()
    {   
        if (GameObject.FindWithTag("enemy") == null){
            enemycount -=1;
            StartCoroutine(EnemyDrop());
        }
    }
}
