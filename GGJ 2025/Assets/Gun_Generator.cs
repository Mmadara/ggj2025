using System;
using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;


public class Gun_Generator : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabGun;
    [SerializeField] private GameObject target;

    public void GenerateTheGun()
    {
        var random = Random.Range(0, prefabGun.Length);
        if (prefabGun[random] != null)
        {
            GameObject gb = Instantiate(prefabGun[random], target.transform.position, quaternion.identity);
        }

        Debug.Log("arma instanciada de index" + random);
    }
/*
   void Update()
   {
       if (Input.GetKeyDown("f")) 
       {
           StartCoroutine("ExampleCoroutine");
       }
   }
   IEnumerator ExampleCoroutine()
   {
       while (true) 
       {
           Debug.Log("Ejecutando tarea: " + Time.time);
           
           yield return new WaitForSeconds(2f);
           GenerateTheGun();
           yield break;
       }
      
   } */
}