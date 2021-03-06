using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectilee : MonoBehaviour
{
    GameObject objectToSpawn3;
    public GameObject projectile3;
    public GameObject projectileWave5;

    public int shotsFired3;
    public int shotsFired4;
    public int shotsFired5;

    public float wave3Velocity;
    public float wave4Velocity;
    public float wave5Velocity;
    public float timeBetweenShots3;
    public float timeBetweenShots4;
    public float timeBetweenShots5;
    public LaunchProjectile launchProjectile;

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
    private float timeWave1;
    private float timeWave2;
    private float timeWave3;
    private float timeWave4;
    public float startWave3;
    public float startWave4;
    public float startWave5;
    



    // Start is called before the first frame update
    void Start()
    {
       // timeWave1 = GameObject.Find("Firepoint").GetComponent<LaunchProjectile>().shotsFired * GameObject.Find("Firepoint").GetComponent<LaunchProjectile>().timeBetweenShots1;
       // timeWave2 = GameObject.Find("Firepoint").GetComponent<LaunchProjectile>().shotsFired2 * GameObject.Find("Firepoint").GetComponent<LaunchProjectile>().timeBetweenShots2;
       // float  startWave3 = timeWave1 + timeWave2;

        StartCoroutine(Example());
        timeWave1 = launchProjectile.shotsFired * launchProjectile.timeBetweenShots1;
        timeWave2 = launchProjectile.shotsFired2 * launchProjectile.timeBetweenShots2;
        timeWave3 = launchProjectile.shotsFired3 * launchProjectile.timeBetweenShots3;
        timeWave4 = launchProjectile.shotsFired4 * launchProjectile.timeBetweenShots4;
        startWave3 = timeWave1 + timeWave2;
        startWave4 = timeWave1 + timeWave2 + timeWave3;
        startWave5 = timeWave1 + timeWave2 + timeWave3 + timeWave4;



    }

    // Update is called once per frame
    void Update()
    {
        
    }


   IEnumerator Example()
   {
  
      WaitForSeconds wait3 = new WaitForSeconds(timeBetweenShots3);
 
      for(int i = 0; i < shotsFired3; i++) 
      {
      FunctionTimer.Create(() => objectToSpawn3 = Instantiate(projectile3, transform.position, Quaternion.Euler(new Vector3(Random.Range(minAngleY3, maxAngleY3), 0, 0))), startWave3, "Timer1"); 
      FunctionTimer.Create(() => objectToSpawn3.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, wave3Velocity, 0)), startWave3, "Timer1");
 
      yield return wait3; 
      }
      WaitForSeconds wait4 = new WaitForSeconds(timeBetweenShots4);
      for(int i = 0; i < shotsFired4; i++) 
      {
      FunctionTimer.Create(() => objectToSpawn3 = Instantiate(projectileWave5, transform.position, Quaternion.Euler(new Vector3(Random.Range(minAngleY4, maxAngleY4), 0, Random.Range(minAngleZ4, maxAngleZ4)))), startWave4, "Timer2"); 
      FunctionTimer.Create(() => objectToSpawn3.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, wave4Velocity, 0)), startWave4, "Timer1");
 
      yield return wait4; 
      }
      WaitForSeconds wait5 = new WaitForSeconds(timeBetweenShots5);
      for(int i = 0; i < shotsFired5; i++) 
      {
      FunctionTimer.Create(() => objectToSpawn3 = Instantiate(projectileWave5, transform.position, Quaternion.Euler(new Vector3(Random.Range(minAngleY5, maxAngleY5), 0, Random.Range(minAngleZ5, maxAngleZ5)))), startWave5, "Timer2"); 
      FunctionTimer.Create(() => objectToSpawn3.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, wave5Velocity, 0)), startWave5, "Timer1");
 
      yield return wait5; 
      }

   }
  
}
