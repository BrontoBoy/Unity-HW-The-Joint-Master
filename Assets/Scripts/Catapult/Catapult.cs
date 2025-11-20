using System.Collections;
using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField] private Rigidbody _attackSpringPoint;
    [SerializeField] private Rigidbody _holdSpringPoint;
    [SerializeField] private Reloader _reloader;
    [SerializeField] private SpringJoint _springJoint;
    
    private bool _isLoaded = true;
    
    public bool IsLoaded => _isLoaded;
    
    private void Start()
    {
        _springJoint.connectedBody = _holdSpringPoint;
        _reloader.Create();
    }
    
    public void OnButtonClick()
    {
        if (_isLoaded)
        {
            _springJoint.connectedBody = _attackSpringPoint;
            _isLoaded = false;
        }
        else
        {
            StartCoroutine(ReloadCoroutine());
        }
    }
    
    private IEnumerator ReloadCoroutine()
    {
        _springJoint.connectedBody = _holdSpringPoint;
        
        yield return new WaitForSeconds(0.5f);
        
        _reloader.Destroy();
        _reloader.Create();
        _isLoaded = true;
    }
}