using Fusion;
using UnityEngine;

//NetworkBehaviour é a herança de classes que trabalham com o online
public class CamController : NetworkBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    //Inicialização do online, subistitui Start e Awake
    public override void Spawned()
    {
        if (HasStateAuthority)
            return;

        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
