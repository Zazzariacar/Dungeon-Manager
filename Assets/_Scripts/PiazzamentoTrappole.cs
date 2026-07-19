using UnityEngine;
using UnityEngine.InputSystem;

public class PiazzamentoTrappole : MonoBehaviour
{
    public Griglia Griglia;
    public GameObject trappola;
    public GameObject camera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Mouse.current.leftButton.wasPressedThisFrame){
            Ray raggio = new Ray(camera.transform.position,camera.transform.forward);
            RaycastHit dato; 
            bool colpito = (Physics.Raycast(raggio, out dato));
            if(colpito == true){
                Vector2Int posizione = Griglia.MondoAGriglia(dato.point);
                Vector3 spawn = Griglia.GrigliaAMondo(posizione);

                
                Griglia.ScriviCella(posizione.x,posizione.y,TipoCella.trappola, trappola);
                Instantiate(trappola,spawn,Quaternion.identity);
            }

        }
    }
}
