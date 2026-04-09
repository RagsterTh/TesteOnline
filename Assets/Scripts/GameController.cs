using Fusion;
using UnityEngine;

public class GameController : NetworkBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public override void Spawned()
    {
        print("start");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
