using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile2 : MonoBehaviour
{
    GameObject objectToSpawn2;
    public GameObject projectile2;
    public GameObject projectilewave4;
    public float wave1Velocity = 750f;
    public float wave2Velocity;
    public float wave3Velocity;
    public float wave4Velocity;
    public float wave5Velocity;
  
    public int shotsFired;
    public int shotsFired2;
    public int shotsFired3;
    public int shotsFired4;
    public int shotsFired5;
    
    
    public float timeBetweenShots1;
    public float timeBetweenShots2;
    public float timeBetweenShots3;
    public float timeBetweenShots4;
    public float timeBetweenShots5;

    public float minAngleY;
    public float maxAngleY;

    public float minAngleZ;
    public float maxAngleZ;

    public float minAngleY2;
    public float maxAngleY2;

    public float minAngleZ2;
    public float maxAngleZ2;
    
    public float minAngleY3;
    public float maxAngleY3;

    public float minAngleZ3;
    public float maxAngleZ3;

    public float minAngleY4;
    public float maxAngleY4;

    public float minAngleZ4;
    public float maxAngleZ4;


    public float minAngleY5;
    public float maxAngleY5;

    public float minAngleZ5;
    public float maxAngleZ5;

    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(Example());
    }

    // Update is called once per frame
    void Update()
    {
      

    }
 
  IEnumerator Example()
  {
   WaitForSeconds wait = new WaitForSeconds(timeBetweenShots1);
 
   for(int i = 0; i < shotsFired; i++) 
   {
      FunctionTimer.Create(() => objectToSpawn2 = Instantiate(projectile2, transform.position, Quaternion.Euler(new Vector3(Random.Range(minAngleY, maxAngleY), 0, Random.Range(minAngleZ, maxAngleZ)))), 2f, "Timer1"); 
      FunctionTimer.Create(() => objectToSpawn2.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, wave1Velocity, 0)), 2f, "Timer1");
 
      yield return wait; 
   }
   WaitForSeconds wait2 = new WaitForSeconds(timeBetweenShots2);
   for(int i = 0; i < shotsFired2; i++) 
   {
      FunctionTimer.Create(() => objectToSpawn2 = Instantiate(projectile2, transform.position, Quaternion.Euler(new Vector3(Random.Range(minAngleY2, maxAngleY2), 0, Random.Range(minAngleZ2, maxAngleZ2)))), 2f, "Timer1"); 
      FunctionTimer.Create(() => objectToSpawn2.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, wave2Velocity, 0)), 2f, "Timer1");
 
      yield return wait2; 
   }
      WaitForSeconds wait3 = new WaitForSeconds(timeBetweenShots3);
 
      for(int i = 0; i < shotsFired3; i++) 
      {
      FunctionTimer.Create(() => objectToSpawn2 = Instantiate(projectile2, transform.position, Quaternion.Euler(new Vector3(Random.Range(minAngleY3, maxAngleY3), 0, Random.Range(minAngleZ3, maxAngleZ3)))), 2f, "Timer1"); 
      FunctionTimer.Create(() => objectToSpawn2.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, wave3Velocity, 0)), 2f, "Timer1");
 
      yield return wait3;
    }
     WaitForSeconds wait4 = new WaitForSeconds(timeBetweenShots4);
 
    for(int i = 0; i < shotsFired4; i++) 
    {
    FunctionTimer.Create(() => objectToSpawn2 = Instantiate(projectilewave4, transform.position, Quaternion.Euler(new Vector3(Random.Range(minAngleY4, maxAngleY4), 0, Random.Range(minAngleZ4, maxAngleZ4)))), 2f, "Timer1"); 
    FunctionTimer.Create(() => objectToSpawn2.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, wave4Velocity, 0)), 2f, "Timer1");
    
 
    yield return wait4; 
    }

     WaitForSeconds wait5 = new WaitForSeconds(timeBetweenShots5);
 
    for(int i = 0; i < shotsFired5; i++) 
    {
    FunctionTimer.Create(() => objectToSpawn2 = Instantiate(projectilewave4, transform.position, Quaternion.Euler(new Vector3(Random.Range(minAngleY5, maxAngleY5), 0, Random.Range(minAngleZ5, maxAngleZ5)))), 2f, "Timer1"); 
    FunctionTimer.Create(() => objectToSpawn2.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, wave5Velocity, 0)), 2f, "Timer1");
    
 
    yield return wait5; 
    }




  }
}