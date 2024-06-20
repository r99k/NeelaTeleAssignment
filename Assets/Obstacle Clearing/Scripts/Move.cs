using UnityEngine;

public class Move : MonoBehaviour
{
     [SerializeField]float speed;
    void Update()
    {
        if (Helper.GameOver == false && Helper.StartGame==true)
        {
            transform.position +=-Vector3.forward*speed * Time.deltaTime;
            if (transform.position.z < -50)
            {
                transform.gameObject.SetActive(false);
            }
        }
        
    }
}
