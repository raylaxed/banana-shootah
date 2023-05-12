using UnityEngine.Events;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public UnityEvent OnGunShoot;
    public float FireCooldown;

    private float CurrentCooldown;
    // Start is called before the first frame update
    void Start()
    {
        CurrentCooldown = FireCooldown;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            
            if(CurrentCooldown <=0f){
                Debug.Log(CurrentCooldown);
                OnGunShoot?.Invoke();
                CurrentCooldown = FireCooldown;

            }

        }
        CurrentCooldown -= Time.deltaTime;
    }
}
