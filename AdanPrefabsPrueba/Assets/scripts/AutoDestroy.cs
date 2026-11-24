using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    float timeleft = 0f;
    void Update()
    {
        timeleft = timeleft + Time.deltaTime;
        if (timeleft > 5f)
        {
            Destroy(this.gameObject);
        }
    }

}
