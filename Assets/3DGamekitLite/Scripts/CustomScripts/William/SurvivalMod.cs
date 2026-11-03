using Gamekit3D;
using UnityEngine;

public class SurvivalMod : MonoBehaviour
{
    [SerializeField]
    private float thirstLevel = 100f;

    [SerializeField] private float thirstSpeed;
    [SerializeField] private float timer = 10f;

    [SerializeField] private bool thirsty;
    [SerializeField] private bool parched;

    [SerializeField] private GameObject playerObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // thirst level gets reduced. min and max thirst defined
        thirstLevel -= Mathf.Clamp(thirstSpeed * Time.deltaTime, 0, thirstLevel);
        if (thirstLevel <= 50f && !thirsty)
        {
           //sets thirsty to true
            Debug.Log("Getting thirsty...");
            thirsty = true;
        }

       //thirst damage
        if (thirstLevel <= 0 && thirsty)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
              Damageable.DamageMessage msg = new Damageable.DamageMessage()
             {
                 amount = 1,
                 damager = this,
                 damageSource = new Vector3(0, 0, 0),
                 direction = new Vector3(0, 0, 0),
                 throwing = false,
                 stopCamera = false
             }
             ;
             
             playerObject.GetComponent<Damageable>().ApplyDamage(msg);
             Debug.Log("Thirst damage");
             timer = 10f;
            }
           
        }
    }
}
