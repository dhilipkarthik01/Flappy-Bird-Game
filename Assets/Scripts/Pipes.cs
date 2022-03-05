using UnityEngine;

public class Pipes : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x-1f;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position += speed*Vector3.left*Time.deltaTime;
        if(transform.position.x<leftEdge){
            Destroy(gameObject);
        }
    }
}
