using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    //キューブの移動速度
    private float speed = -12;

    //消滅位置
    private float deadline = -10;

    //blockの音声
    public AudioClip block;

    //音を鳴らす回数
    private int blockTimes = 1;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //画面外に出たら破棄する
        if (transform.position.x < this.deadline)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (blockTimes > 0)
        {
            GetComponent<AudioSource>().PlayOneShot(block);
            blockTimes -= 1;
        }
    }
}
