using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Hallway : MonoBehaviour
{

     public GameObject enemy;

     void Awake()
     {
         enemy = GameObject.FindWithTag("Enemy");
     }
     /*void Update()
     {
        scr_Projectile dollar = other.GetComponent<scr_Projectile>();
        if (dollar = null)
        {
            dollar.pEnteredTrigger = false;
        }
     }*/
     private void OnTriggerEnter (Collider other)
     {
             scr_Player player = other.GetComponent<scr_Player>();
             scr_Projectile dollar = other.GetComponent<scr_Projectile>();
             if (other.tag == "pDollar")
             {
                 dollar.pEnteredTrigger = true;
                 enemy.GetComponent<scr_Enemy>().greed = 2;
                 Debug.Log("dollar exists" + dollar.pEnteredTrigger);
             }
             else if (other.tag == "Player")
             {
                 player.enteredTrigger = true;
                enemy.GetComponent<scr_Enemy>().greed = 1;
                Debug.Log (player.enteredTrigger);
            }
     }
     private void OnTriggerStay (Collider other)
     {
          scr_Player player = other.GetComponent<scr_Player>();
          scr_Projectile dollar = other.GetComponent<scr_Projectile>();
             if (other.tag == "pDollar")
             {
                 dollar.pEnteredTrigger = true;
                 enemy.GetComponent<scr_Enemy>().greed = 2;
                 //Debug.Log("dollar entered trigger" + dollar.pEnteredTrigger);
             }
            else if (other.tag == "Player")
            {
            player.enteredTrigger = true;
            enemy.GetComponent<scr_Enemy>().greed = 1;
            //Debug.Log (player.enteredTrigger);
            }
     }
     public void OnTriggerExit (Collider other)
     {
            scr_Projectile dollar = other.GetComponent<scr_Projectile>();
            if (other.tag == "pDollar")
             {
                 dollar.pEnteredTrigger = false;
                enemy.GetComponent<scr_Enemy>().greed = 0;
                 Debug.Log("dollar exists" + dollar.pEnteredTrigger);
             }
          scr_Player player = other.GetComponent<scr_Player>();
          if (other.tag == "Player")
          {
              player.enteredTrigger = false;
            enemy.GetComponent<scr_Enemy>().greed = 0;
                //Debug.Log (player.enteredTrigger);
          }
     }
}
