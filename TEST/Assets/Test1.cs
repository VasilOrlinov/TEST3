using UnityEngine;
using System.Collections;

public class Test1: MonoBehaviour
{
    public GameObject _object;
    public GameObject _player;
       
    void Start()
    {
        
    }

   void Update()
    {
        transform.LookAt(_player.transform);
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}