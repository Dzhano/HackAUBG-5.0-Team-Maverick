using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stone : MonoBehaviour
{
    public Route currentRoute;

    int routePosition;

    static public int steps;

    bool isMoving;

    

    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space) && !isMoving && SceneManager.sceneCount < 2)
        {
            if(SceneManager.GetActiveScene().buildIndex == 2)
            {
                SceneManager.LoadSceneAsync(0, LoadSceneMode.Additive);
            }
            // steps = GetComponent<Answ>;
            // Debug.Log("Dice Rolled " + steps);

            
            

            // if(routePosition + steps < currentRoute.childNodeList.Count)
            // {
            //     StartCoroutine(Move());
            // }
            // else
            // {
            //     Debug.Log("Rolled Number is too high");
            // }
        }
        StartCoroutine(Move());

    }

    IEnumerator Move()
    {
        if(isMoving)
        {
            yield break;
        }
        isMoving = true;

        while(steps > 0)
        {
            yield return new WaitForSeconds(1);
            routePosition++;
            if((routePosition % currentRoute.childNodeList.Count) == 0)
            {
                steps = 0;
                routePosition = 0;
                SceneManager.LoadScene(1, LoadSceneMode.Single);    
            }
            
            Vector3 nextPos = currentRoute.childNodeList[routePosition].position;
            while(MoveToNextNode(nextPos)){yield return null;}

            yield return new WaitForSeconds(0.1f);
            steps--;
            // routePosition++;
        }
        isMoving = false;
    }

    bool MoveToNextNode(Vector3 goal)
    {
        return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 2f * Time.deltaTime));
    }
}
