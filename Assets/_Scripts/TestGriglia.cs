using UnityEngine;

public class TestGriglia : MonoBehaviour
{
    public Griglia griglia;

    void Start()
    {
        if (griglia == null)
        {
            Debug.LogError("TestGriglia: la griglia non è assegnata.");
            return;
        }

        griglia.ScriviCella(3, 4, TipoCella.trappola, null);
        Cella risultato = griglia.LeggiCella(3, 4);
        if (risultato != null && risultato.tipo == TipoCella.trappola)
        {
            Debug.Log("Test scrittura/lettura: OK - Cella (3,4) scritta e letta correttamente come trappola.");
        }
        else
        {
            Debug.LogError($"Test scrittura/lettura: ERRORE - risultato={(risultato == null ? "null" : risultato.tipo.ToString())}");
        }

        Vector3 coord = new Vector3(3, 0, 8);
        Vector2Int ris = griglia.MondoAGriglia(coord);
        Vector3 coordRitorno = griglia.GrigliaAMondo(ris);
        Vector2Int ris2 = griglia.MondoAGriglia(coordRitorno);

        if (ris == ris2)
        {
            Debug.Log($"Conversione mondo->griglia->mondo->griglia: OK - coord={coord}, griglia={ris}, ritorno={ris2}");
        }
        else
        {
            Debug.LogError($"Conversione errata: coord={coord}, prima={ris}, dopo={ris2}");
        }

        Cella risultato2 = griglia.LeggiCella(4, 3);
        if (risultato2 == null || risultato2.tipo != TipoCella.nulla)
        {
            Debug.LogError($"Test cella non valida: ERRORE - atteso null, ottenuto tipo={risultato2.tipo}");
        }
        else
        {
            Debug.Log("Test inversione indici: OK - (4,3) è vuota, nessuna trappola letta per sbaglio.");
        }
    }

    void Update()
    {
    }
}
