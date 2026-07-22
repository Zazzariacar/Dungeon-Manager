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

    
    void Update()
{
    if (Mouse.current.leftButton.wasPressedThisFrame)
    {
        Ray raggio = new Ray(camera.transform.position, camera.transform.forward);
        RaycastHit dato;
        bool colpito = (Physics.Raycast(raggio, out dato));
        if (colpito == true)
        {
            Vector2Int posizione = Griglia.MondoAGriglia(dato.point);
            Cella letturaTipo = Griglia.LeggiCella(posizione.x,posizione.y);
            if (!Griglia.CellaValida(posizione.x, posizione.y))
            {
                Debug.Log("Cella non valida");
                return;
            }
            else if (letturaTipo.tipo == TipoCella.trappola)
            {
                Debug.Log("Trappola già presente in questa cella");
                return;
            } else if(letturaTipo.tipo == TipoCella.nulla ){
                Vector3 spawn = Griglia.GrigliaAMondo(posizione);
                
                Griglia.ScriviCella(posizione.x, posizione.y, TipoCella.trappola, trappola);
                Instantiate(trappola, spawn, Quaternion.identity);
            }else{
                Debug.Log("Non possibile piazzare");
            }
           
        }
    }
}
}
