using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tank : MonoBehaviour
{
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Bullet _buletTemplate;
    [SerializeField] private float _delayBetweemShoots;
    [SerializeField] private float _recoilDistance;


    private float _timeAfterShoot;

    private void Update()
    {
        _timeAfterShoot += Time.deltaTime;
        if(Input.GetMouseButton(0))
        {
            if(_timeAfterShoot>_delayBetweemShoots)
            {
                Shoot();
                transform.DOMoveZ(transform.position.z - _recoilDistance, _delayBetweemShoots/2).SetLoops(2,LoopType.Yoyo);
                _timeAfterShoot = 0;
            }
                
            
        }
    }

    private void Shoot()
    {
        Instantiate(_buletTemplate, _shootPoint.position, Quaternion.identity);
    }
}

