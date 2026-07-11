using UnityEngine;

public enum TipoCella {
    nulla,muro,trappola,spawnEroi,mostro,oggetto
}

public class Cella {
    public TipoCella tipo;
    public GameObject oggettoPiazzato;
}

public class Griglia : MonoBehaviour
{
  public int Altezza = 10;
  public int Largezza = 10;
  public float dimensioneCella = 2f;

  Cella[,] celle;

  public void Awake(){
    Vector3 posizione = new Vector3();
    celle = new Cella[Altezza,Largezza];
    for (int Riga = 0; Riga < Altezza; Riga++)
    {
       for(int Colonna = 0; Colonna < Largezza;Colonna++){
        
        celle[Riga,Colonna] = new Cella();
           Debug.Log("Cella creata in posizione: " + Riga + "," + Colonna);
       
       } 
    }
  

  }
  public Vector2Int MondoAGriglia(Vector3 posizione)
    {
        float colonna = posizione.x / dimensioneCella   ;
        float riga =   posizione.z / dimensioneCella  ;
        colonna = Mathf.FloorToInt(colonna);
        riga = Mathf.FloorToInt(riga);
        return new Vector2Int((int)colonna,(int)riga);
    }

    public Vector3 GrigliaAMondo(Vector2Int cellaIndice)
    {
         float x = cellaIndice.x * dimensioneCella  ;
         x = x + (dimensioneCella / 2);
         float z =   cellaIndice.y * dimensioneCella ;
         z = z + (dimensioneCella / 2);
         
        return new Vector3(x,0,z);
    }

    public bool CellaValida(int x, int y)
    {
        if(y < 0 || y >= Altezza)
        {
           
            return false;
        }
        else if(x < 0 || x >= Largezza)
        {
            
            return false;    
        }
        else
        {
            return true;
        }
    }

    public Cella LeggiCella(int x, int y)
    {
      bool token = CellaValida(x,y);
      if(token == true)
        {
            return celle[x,y];
        }
        else
        {
            Debug.Log("ErrorCellaNonEsiste");
            return null;
        }
    }

    public Cella ScriviCella(int x, int y, TipoCella tipo, GameObject oggetto)
    {
         bool token = CellaValida(x,y);
      if(token == true)
        {
           celle[x,y].tipo = tipo;
           celle[x,y].oggettoPiazzato = oggetto;
           return celle[x,y];
        }
        else
        {
            return null;
        }
    }
}

