using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticoliWebService.Models;

namespace ArticoliWebService.Services
{
    public interface IArticoliRepository
    {
        IEnumerable<Articoli> SelArticoliByDescrizione(string Descrizione);
        Articoli SelArticoliByCodice(string Code);
        Articoli SelArticoliByEan(string Ean);

        bool InsArticoli(Articoli articolo);
        bool UpdArticoli(Articoli articolo);
        bool DelArticoli(Articoli articolo);
        bool Salva();

    }
}