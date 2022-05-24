using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectilee : MonoBehaviour
{
    GameObject objectToSpawn3;
    public GameObject projectile3;
    public float wave3Velocity = 750f;
    bool instantiated1;
    public int shotsFired3;
    public int shotsFired4;
    public float wave4Velocity;
    public float timeBetweenShots3;
    public float timeBetweenShots4;

    public float minAngleY;
    public float maxAngleY;

    public float minAngleZ;
    public float maxAngleZ;

    public float minAngleY2;
    public float maxAngleY2;

    public float minAngleZ2;
    public float maxAngleZ2;
    private float timeWave1;
    private float timeWave2;
    public float startWave3;
   
    



    // Start is called before the first frame update
    void Start()
    {
        timeWave1 = GameObject.Find("Firepoint").GetComponent<LaunchProjectile>().shotsFired * GameObject.Find("Firepoint").GetComponent<LaunchProjectile>().timeBetweenShots1;
        timeWave2 = GameObject.Find("Firepoint").GetComponent<LaunchProjectile>().shotsFired2 * GameObject.Find("Firepoint").GetComponent<LaunchProjectile>().timeBetweenShots2;
        float  startWave3 = timeWave1 + timeWave2;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator Example()
  {
   WaitForSeconds wait = new WaitForSeconds(timeBetweenShots3);
 
   for(int i = 0; i < shotsFired3; i++) 
   {
      FunctionTimer.Create(() => objectToSpawn3 = Instantiate(projectile3, transform.position, Quaternion.Euler(new Vector3(Random.Range(minAngleY, maxAngleY), 0, 0))), startWave3, "Timer1"); 
      FunctionTimer.Create(() => objectToSpawn3.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, wave3Velocity, 0)), startWave3, "Timer1");
 
      yield return wait; 
   }
    WaitForSeconds wait2 = new WaitForSeconds(timeBetweenShots4);
    for(int i = 0; i < shotsFired4; i++) 
   {
      FunctionTimer.Create(() => objectToSpawn3 = Instantiate(projectile3, transform.position, Quaternion.Euler(new Vector3(Random.Range(minAngleY2, maxAngleY2), 0, Random.Range(minAngleZ2, maxAngleZ2)))), 60f, "Timer1"); 
      FunctionTimer.Create(() => objectToSpawn3.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, wave4Velocity, 0)), 60f, "Timer1");
 
      yield return wait2; 
   }


  }
}
