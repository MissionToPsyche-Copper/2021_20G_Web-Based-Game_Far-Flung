using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    private Vector3 _launchDirection;
    private float _launchPower;
    private Rigidbody _body;
    private Attractor _attractor;
    private bool _launched;

    // Start is called before the first frame update
    void Start()
    {
        _body = GetComponent<Rigidbody>();
        _attractor = GetComponent<Attractor>();
        _attractor.Affected = false;
        _launched = false;

    }

    public void DoLaunch()
    {
        if (!_launched)
        {
            _attractor.Affected = true;
            _body.AddForce(_launchDirection * _launchPower, ForceMode.VelocityChange);
            _launched = true;
        }
    }

    public bool HasLaunched()
    {
        return _launched;
    }

    public void SetAngle(float angle)
    {
        float xDirection = Mathf.Cos(angle * (3.14f / 180f));
        float yDirection = Mathf.Sin(angle * (3.14f / 180f));
        _launchDirection = new Vector3(xDirection, yDirection, 0);
    }

    public void SetPower(float power)
    {
        _launchPower = power;
    }
}
