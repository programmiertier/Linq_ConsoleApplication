using System;
using System.Collections.Generic;
using System.Linq;      // diese library brauchen wir
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Linq_ConsoleApplication
{
    class Program
    {
        static void warten()
        {
            WriteLine("-----");
            WriteLine("Weiter mit Enter");
            ReadLine();
        }

        static int verdoppeln(int zahl)
        {
            return zahl * 2;
        }

        static void Main(string[] args)
        {
            /* Warenkatalog wkatalog = new Warenkatalog();
            // foreach ( Artikel item in wkatalog)     braucht immer Enumerable Daten
            for (int id = 0; id < Warenkatalog.warenkatalog.Length; id++)
            {
                WriteLine("Artikel: {0},\tVolumen: {1},\tPreis: {2}", 
                    Warenkatalog.warenkatalog[id].artikel_id, 
                    Warenkatalog.warenkatalog[id].artikel_volumen, 
                    Warenkatalog.warenkatalog[id].artikel_preis);
            }   */

            // in SQL SELECT * FROM Warenkatalog.warenkatalog -> alle Inhalte Spalten und Zeilen
            //                      Quelle / Table
            /* var artikelliste = from artikel in Warenkatalog.warenkatalog select artikel;    // in LINQ Syntax
                  // from = Bereichsangabe // name beliebig!
            foreach(var item in artikelliste)
            {
                WriteLine("Artikel: {0},\tVolumen: {1},\tPreis: {2}", 
                    item.artikel_id, 
                    item.artikel_volumen, 
                    item.artikel_preis);
            }
            warten();

            // in SQL: select volumen from Warenkatalog.warenkatalog
            var artikelvolumen = from artikel in Warenkatalog.warenkatalog select artikel.artikel_volumen;
            foreach (var item in artikelvolumen)
            {
                WriteLine("Volumen: {0}", item);
            }
            warten();

            var artikelpreis = from artikel in Warenkatalog.warenkatalog select artikel.artikel_preis;
            foreach (var item in artikelpreis)
            {
                WriteLine("Preis: {0}", item);
            }
            warten();   */

            // Select mit berechnetem Ergebnis aus einer Spalte
            var artikelImRegal = from artikel in Warenkatalog.warenkatalog select (int)(1.0 / artikel.artikel_volumen);
            foreach ( var item in artikelImRegal)
            {
                WriteLine("Artikel Im Regal: {0}", item);       // entweder hier (int)item oder nach dem select (int)()
            }
            warten();

            // Methode im LINQ aufgerufen
            var doppelteImRegal = from artikel in Warenkatalog.warenkatalog select verdoppeln((int)(1.0 / artikel.artikel_volumen));
            foreach( var item in doppelteImRegal)
            {
                WriteLine("Doppeltes im Regal: {0}", item);
            }
            warten();

            // Select mit berechnetem Ergebnis aus mehreren Spalten
            var regalWert = from artikel in Warenkatalog.warenkatalog select ((int)(1.0 / artikel.artikel_volumen) * artikel.artikel_preis);
            foreach (var item in regalWert)
            {
                WriteLine("Wert im Regal: {0}", item);       // entweder hier (int)item oder nach dem select (int)()
            }
            warten();

            // Select mit berechnetem Ergebnis aus mehreren  Spalten  und einer Spalte, wie AS in SQL
            var idUndRegalwert = from artikel in Warenkatalog.warenkatalog select new { id = artikel.artikel_id,
                                                                                        wert = ((int)(1.0 / artikel.artikel_volumen)) * artikel.artikel_preis };    // in LINQ Syntax
            foreach (var item in idUndRegalwert)
            {
                WriteLine("Regal: {0} hat den Wert: {1,4:F2}", item.id, item.wert);
            }
            warten();
        }
    }
}
