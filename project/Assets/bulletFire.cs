using UnityEngine;
using System.Collections;

public class bulletFire : MonoBehaviour {

    public GameObject BulletPrefab;
    //public GameObject spawnSpot;
    public GameObject spawnSpot; //= new Vector3(0, 2, 0);

    void Update()
    {
   if (Input.GetKeyDown(KeyCode.R)) {
            
               
      GameObject cubeSpawn = (GameObject)Instantiate(BulletPrefab, spawnSpot.transform.position, Quaternion.identity);
            // getameObject.Find("spawn").transform.position; Quaternion.identity)
      cubeSpawn.GetComponent<Rigidbody>().AddForce(transform.forward * 5.5f);

        }
    }
}
