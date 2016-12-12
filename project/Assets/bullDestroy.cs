using UnityEngine;
using System.Collections;

public class bullDestroy : MonoBehaviour {

    //bullet will destroy when collided with wall
    void OnCollisionExit(Collision collisionInfo)
    {
        if (collisionInfo.transform.CompareTag("enemy"))
            print("yayyy destroyed!");
            Destroy(gameObject);
    }

}
