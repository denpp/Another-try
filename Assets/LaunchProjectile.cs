using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
 
GameObject objectToSpawn;
    public GameObject projectile;
    public float wave1Velocity = 750f;
    public int shotsFired;
    public int shotsFired2;
    public float wave2Velocity = 1000f;
    
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
   WaitForSeconds wait = new WaitForSeconds(3);
 
   for(int i = 0; i < shotsFired; i++) 
   {
      FunctionTimer.Create(() => objectToSpawn = Instantiate(projectile, transform.position, Quaternion.Euler(Random.Range(minAngleY,maxAngleY ), 0, Random.Range(minAngleZ, maxAngleZ))), 3f, "Timer1"); 
      FunctionTimer.Create(() => objectToSpawn.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, wave1Velocity, 0)), 3f, "Timer1");
 
      yield return wait; 
   }
   WaitForSeconds wait2 = new WaitForSeconds(1);
   for(int i = 0; i < shotsFired2; i++) 
   {
    FunctionTimer.Create(() => objectToSpawn = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(Random.Range(minAngleY2, maxAngleY2), 0, Random.Range(minAngleZ2, maxAngleZ2)))), 1f, "Timer1"); 
    FunctionTimer.Create(() => objectToSpawn.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, wave2Velocity, 0)), 1f, "Timer1");
 
    yield return wait2; 
   }


  }
}