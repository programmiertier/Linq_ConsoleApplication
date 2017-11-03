internal class Artikel
    {
        private int _artikel_id;
        private double _artikel_volumen;
        private double _artikel_preis;

    public double artikel_preis
    {
        get
        {
            return _artikel_preis;
        }
    }

    public double artikel_volumen
    {
        get
        {
            return _artikel_volumen;
        }
    }

    public int artikel_id
    {
        get
        {
            return _artikel_id;
        }
    }



    public Artikel()
    {
            //  WriteLine("Artikel  angelegt:");
    }

    public Artikel(int id, Artikel[] wkatalog)
    { // WriteLine("Artikel {0} angelegt: ", wk[id]._art_id);
        _artikel_id = wkatalog[id]._artikel_id;
        _artikel_volumen = wkatalog[id]._artikel_volumen;//1.0/((double)id*3);
        _artikel_preis = wkatalog[id]._artikel_preis; // 1.0 / ((double) id * 5) ;
            //  WriteLine("Der Artikel hat ein Volumen von {0:F2} und einen Preis von {1:F2}", _art_volumen, _art_einzelpreis);
    }

    public Artikel(int id, double volumen, double preis)
    {
        // WriteLine("Artikel {0} angelegt: ", id);
        _artikel_id = id;
        _artikel_volumen = volumen;
        _artikel_preis = preis;
    }
}