using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactCode : MonoBehaviour
{
    private int limite;
    private SpriteRenderer spriteR;
    [SerializeField] private Sprite[] sprites;
    [SerializeField] GameObject bomb;
    // Start is called before the first frame update
    void Start()
    {
        limite = 0;
        spriteR = GetComponent<SpriteRenderer>();
        spriteR.sprite = sprites[0];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > 4 && collision.relativeVelocity.magnitude < 10)
        {
            if (limite < sprites.Length - 1)
            {
                limite++;
                spriteR.sprite = sprites[limite];
            }
            else if (limite == sprites.Length - 1)
            {
                Instantiate(bomb, new Vector2(transform.position.x, transform.position.y), transform.rotation);
                Destroy(gameObject);

            }
        }
        else if (collision.relativeVelocity.magnitude > 12 && collision.gameObject.CompareTag("Player"))
        {
            Instantiate(bomb, new Vector2(transform.position.x, transform.position.y), transform.rotation);
            Destroy(gameObject);

        }
    }

}
