using UnityEngine;

public class Swing : MonoBehaviour
{
    [SerializeField] private Rigidbody _barRigidbody;
    [SerializeField] private float _torque = 50f;
    [SerializeField] private float _swingTime = 2f;
    
    private int _direction = 1;
    private bool _isSwinging;
    
    private void FixedUpdate()
    {
        if (_isSwinging && _barRigidbody != null)
        {
            _barRigidbody.AddRelativeTorque(0, _torque * _direction, 0, ForceMode.Force);
        }
    }
    
    public void OnClick()
    {
        StartSwinging();
    }

    private void StartSwinging()
    {
        _direction *= -1;
        IsSwingingActive();
        Invoke(nameof(IsSwingingDeactive), _swingTime);
    }
    
    private void IsSwingingActive()
    { 
        _isSwinging = true;
    }
    
    private void IsSwingingDeactive()
    {
        _isSwinging = false;
    }
}