using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;


[DisallowMultipleComponent]
public class die : MonoBehaviour
{
    [SerializeField] Text attempts;
    [SerializeField] Text time;
    Vector3 tempPos;
    public int death = 1;
    float di = 0f;
    float globaltime = 0f;

    // Start is called before the first frame update
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        globaltime = Time.time;
        tempPos = this.transform.position;
        //Destroy(this.gameObject);
        tempPos.y = 1.2f;
        tempPos.x = 0f;
        transform.position = tempPos;
        death += 1;
        UpdateText(death+1);
        //t.Wait(10);
    }
    public void UpdateText(int score)
    {
        attempts.text = score.ToString();
    }
    void Update()
    {
        di = Time.time - Time.time % 0.01f - globaltime;
        time.text = di.ToString();
    }

}
