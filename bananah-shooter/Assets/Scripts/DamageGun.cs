using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageGun : MonoBehaviour
{
    public float Damage;
    public float BulletRange;
    private Transform PlayerCamera;
    private Transform PlayerCameraCamPos;

    // Start is called before the first frame update
    void Start()
    {
        PlayerCamera = GameObject.Find("Player").transform;
        Debug.Log(PlayerCamera.position);
        PlayerCameraCamPos = GameObject.Find("Main Camera").transform;
        Debug.Log(PlayerCameraCamPos.position);
    }
    public void Shoot(){
        


        Ray gunRay = new Ray(PlayerCameraCamPos.position, PlayerCameraCamPos.forward);
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
