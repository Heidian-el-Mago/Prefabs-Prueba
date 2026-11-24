using UnityEngine;

public class Prefabs : MonoBehaviour
{
    public GameObject objeto;
    public GameObject puntoMira;
    float fuerzaDisparo = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            var bala = Instantiate(objeto, puntoMira.transform.position, transform.rotation);
            bala.GetComponent<Rigidbody>().AddForce(Vector3.forward * fuerzaDisparo, ForceMode.Impulse);
        }
    }
}
