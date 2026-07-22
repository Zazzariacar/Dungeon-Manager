using UnityEngine;

public class GeneratoreLivello : MonoBehaviour
{
    public Griglia Griglia;
    public GameObject Muro;

    void Start()
    {
        for(int x = 0;x < Griglia.Larghezza; x++  ){
            for(int y = 0; y < Griglia.Altezza; y++){
                bool bordo = (x == 0 || x == Griglia.Larghezza-1 || y == 0 || y == Griglia.Altezza-1);
                if(bordo == true){
                    Vector3 spawn = Griglia.GrigliaAMondo(new Vector2Int(x,y));
                    GameObject muroIstanziato = Instantiate(Muro, spawn, Quaternion.identity);
                    muroIstanziato.transform.localScale = new Vector3(Griglia.dimensioneCella, Griglia.dimensioneCella, Griglia.dimensioneCella);
                    Griglia.ScriviCella(x, y, TipoCella.muro, muroIstanziato);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
