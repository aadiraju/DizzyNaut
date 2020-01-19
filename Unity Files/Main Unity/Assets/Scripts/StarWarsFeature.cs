using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarWarsFeature : MonoBehaviour
{   
    // rotate around method
    //add sc to hero
    public int points = 3;
    public GameObject target; //the object u gonna rotate
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void Use()
    {
        if(points >= 3)
        {
            points -= 3;
            target.GetComponent<Transform>().RotateAround(transform.position, Vector2.right, 30 * Time.deltaTime);
            ExplosionDamage(transform.position, 5);
        }
    }
    void ExplosionDamage(Vector3 center, float radius)
    {
        //https://docs.unity3d.com/ScriptReference/Physics.OverlapSphere.html
        Collider[] hitColliders = Physics.OverlapSphere(center, radius);
        //Collider[] hitColliders = Physics.OverlapSphere(center, radius);
        int i = 0;
        while (i < hitColliders.Length)
        {   
            hitColliders[i].gameObject.GetComponent<Transform>().position += hitColliders[i].gameObject.GetComponent<Transform>().position - center;
            i++;
        }
    }
}
