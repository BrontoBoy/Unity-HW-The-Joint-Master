using UnityEngine;

using UnityEngine;

public class Reloader : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject _missilePrefab;
    
    private GameObject _currentMissile;
    
    public void Create()
    {
        if (_missilePrefab != null && _spawnPoint != null)
        {
            _currentMissile = Instantiate(_missilePrefab, _spawnPoint.position, Quaternion.identity);
        }
    }
    
    public void Destroy()
    {
            Destroy(_currentMissile);
    }
}