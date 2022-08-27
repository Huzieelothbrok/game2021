using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy;
    public int xpos;
    public int zpos;
    public int Enecount;
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }
    IEnumerator EnemyDrop(){
        while (Enecount < 10)
        {
            xpos = Random.Range(-23,9);
            zpos = Random.Range(65, 115);
            Instantiate(Enemy, new Vector3(xpos, 39, zpos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            Enecount += 1;

        }
    }
    
}
