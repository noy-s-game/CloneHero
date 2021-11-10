using System.Collections;
using UnityEngine;

public class Activator : MonoBehaviour
{
    SpriteRenderer sr;
    public KeyCode key;
    public float colorChange = 0.1f;
    bool active = false;
    GameObject note;
    Color old;

    void Awake() {
        sr = GetComponent<SpriteRenderer>();
;    
    }
    // Start is called before the first frame update
    void Start()
    {
        old = sr.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key)) { StartCoroutine(Pressed()); }

        if (Input.GetKeyDown(key) && active) {
            Destroy(note);            
        }
        
    }

    void OnTriggerEnter2D(Collider2D col) {
        active=true;
        if (col.gameObject.tag == "Note")
            note = col.gameObject;
    
    }

    void OntriggerExit2D(Collider2D col) {
        active = false;
    
    }

    IEnumerator Pressed() {
        Color old = sr.color;
        sr.color = new Color(0, 0, 0);
        yield return new WaitForSeconds(colorChange);
        sr.color = old;

    
    }
}
