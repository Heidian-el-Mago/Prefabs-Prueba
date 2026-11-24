using UnityEngine;

public class Prefabs : MonoBehaviour
{
    public GameObject objeto;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(objeto, transform.position, transform.rotation);
        }
    }
}
