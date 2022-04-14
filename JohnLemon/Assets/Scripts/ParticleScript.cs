using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class ParticleScript : MonoBehaviour
{   
    private GameObject player;
    private GameObject ending;
    

    private ParticleSystem ps;

    private GameObject[] enemies;
    
    // Start is called before the first frame update
   void Start()
    {
        ps = GetComponent<ParticleSystem>();
        
        player = GameObject.FindGameObjectWithTag("JohnLemon");
        
     
    }
    // Update is called once per frame
    void Update()
    {
        Transform enemy = FindClosestEnemy();
        //enemy.gameObject.GetComponent<Renderer>().material.color = new Color(255,255,0,1);
        //float dist = Mathf.Abs(Vector3.Distance(player.transform.position,enemy.position));
        float dotResult = Mathf.Abs(Vector3.Dot(player.transform.position,enemy.position));
        
        var main = ps.main;
        Debug.Log(dotResult);
        //main.startSize = 1 - dist/10;
        main.startSpeed = dotResult/30;
        
    }
    public Transform FindClosestEnemy(){
        
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float closest = Mathf.Infinity;
        Transform trans = null;

        foreach( GameObject enemy in enemies){
            float distance;
            distance = Vector3.Distance(transform.position,enemy.transform.position);

            if (distance < closest){
                closest = distance;
                trans = enemy.transform;
            }
        }

        return trans;

        

    }
}