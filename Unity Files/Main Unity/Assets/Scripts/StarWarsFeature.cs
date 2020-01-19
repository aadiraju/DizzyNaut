using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarWarsFeature : MonoBehaviour
{   
    // rotate around method
    //add sc to hero
    public int points = 3;
    public GameObject target; //the object u gonna rotate
    public bool z = false;
    public float timeLeft = .6f;
    public GameObject ExGO;
    Vector3 targetV;
    Vector3 blade;
    Vector3 result;
    public float forceP = 11;
    void Start()
    {
        target.GetComponent<MeshRenderer>().enabled = false;
    }

    void FixedUpdate()
    {
        
        Use();
        
        //ExGO.transform.position = result;
        //ExGO.GetComponent<Rigidbody>().AddForce(result * forceP);
    }
    
    void Use()
    {
        if (z)
        {
            target.GetComponent<MeshRenderer>().enabled = true;
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0) Stop();
            target.GetComponent<Transform>().RotateAround(transform.position, Vector2.up, 800 * Time.deltaTime);
            //ExplosionDamage(transform.position, 1);
        }

        
        

    }
    public void useSWF()
    {
        z = true;
    }
    private void Stop()
    {
        z = false;
        target.GetComponent<MeshRenderer>().enabled = false ;
        timeLeft = .6f;

    }
    void ExplosionDamage(Vector3 center, float radius)
    {
        Debug.Log("ExpDamageMETHOD");
        //https://docs.unity3d.com/ScriptReference/Physics.OverlapSphere.html
        Collider[] hitColliders = Physics.OverlapSphere(center, radius);
        //Collider[] hitColliders = Physics.OverlapSphere(center, radius);
        int i = 0;
        while (i < hitColliders.Length)
        {
            if (hitColliders[i].gameObject.tag != "Player")
            {
                targetV = transform.position;
                blade = hitColliders[i].gameObject.transform.position;
                result = targetV - blade;
                hitColliders[i].gameObject.GetComponent<Rigidbody>().AddForce(result*forceP) ;
                i++;
            }
        }
    }
}
