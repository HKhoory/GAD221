using UnityEngine;



public class TurnToPlayer : MonoBehaviour
{
    public Transform player;


      

   
    void Update()
    {

        if (player == null)
        {

            return;

        }


        Vector3 direction = player.position - transform.position;

        direction.y = 0;


        if (direction.sqrMagnitude > 0.001f)
        {

            transform.rotation = Quaternion.LookRotation(direction);

        }


    }




}
