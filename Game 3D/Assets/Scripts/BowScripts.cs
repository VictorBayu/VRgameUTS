using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowScripts : MonoBehaviour
{
    float _charge;

    public float ChargeMax;
    public float ChargeRate;

    public KeyCode fireButton;

    public Transform spawn;
    public Rigidbody arrowObj;

    void Update()
    {
        if(Input.GetKey(fireButton) && _charge < chargeMax)
        {
            _charge += Time.deltaTime * chargeRate;
            Debug.Log(_charge.ToString());
        }

        if (Input.GetKeyUp(fireButton))
        {
            Rigidbody arrow = Instantiate(arrowObj, spawn.position, Quaternion.identity) as Rigidbody;
            arrow.AddForce(spawn.forward * _charge, ForceMode.Impulse);
            _charge = 0;
        }
    }
}
