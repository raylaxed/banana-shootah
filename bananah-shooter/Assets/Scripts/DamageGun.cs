using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageGun : MonoBehaviour
{
    public float Damage;
    public float BulletRange;
    private Transform PlayerCamera;

    // Start is called before the first frame update
    void Start()
    {
        PlayerCamera = GameObject.Find("Player").transform;
    }
    public void Shoot(){
        


        Ray gunRay = new Ray(PlayerCamera.position, PlayerCamera.forward);
        Debug.Log(PlayerCamera.position);
        
        if(Physics.Raycast(gunRay, out RaycastHit hitInfo, BulletRange)){
            Debug.Log(hitInfo.collider);
            //Debug.Log(hitInfo.collider.gameObject.TryGetComponent(out Entity enemy));
            if(hitInfo.collider.gameObject.TryGetComponent(out Entity enemy)){
                Debug.Log("GunRay");
               enemy.Health -= Damage;
            }


        }
    }
}
