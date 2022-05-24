using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile1 : MonoBehaviour
{
    GameObject objectToSpawn1;
    public GameObject projectile1;
    public float wave1Velocity = 750f;
    bool instantiated1;
    public int shotsFired;
    public int shotsFired2;
    public float wave2Velocity;
    public float timeBetweenShots1;
    public float timeBetweenShots2;

    public float minAngleY;
    public float maxAngleY;

    public float minAngleZ;
    public float maxAngleZ;

    public float minAngleY2;
    public float maxAngleY2;

    public float minAngleZ2;
    public float maxAngleZ2;


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
      FunctionTimer.Create(() => objectToSpawn1 = Instantiate(projectile1, transform.position, Quaternion.Euler(new Vector3(Random.Range(minAngleY, maxAngleY), 0, Random.Range(minAngleZ, maxAngleZ)))), 2f, "Timer1"); 
      FunctionTimer.Create(() => objectToSpawn1.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, wave1Velocity, 0)), 2f, "Timer1");
 
      yield return wait; 
   }
    WaitForSeconds wait2 = new WaitForSeconds(timeBetweenShots2);
    for(int i = 0; i < shotsFired2; i++) 
   {
      FunctionTimer.Create(() => objectToSpawn1 = Instantiate(projectile1, transform.position, Quaternion.Euler(new Vector3(Random.Range(minAngleY2, maxAngleY2), 0, Random.Range(minAngleZ2, maxAngleZ2)))), 2f, "Timer1"); 
      FunctionTimer.Create(() => objectToSpawn1.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, wave2Velocity, 0)), 2f, "Timer1");
 
      yield return wait2; 
   }
  }
  
}