using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticoliWebService.Models;

namespace ArticoliWebService.Services
{
    public class ArticoliRepository : IArticoliRepository
    {

        AlphaShopDbContext alphaShopDbContext;

        public ArticoliRepository(AlphaShopDbContext alphaShopDbContext)
        {
            this.alphaShopDbContext = alphaShopDbContext;
        }

        public IEnumerable<Articoli> SelArticoliByDescrizione(string Descrizione)
        {
            return this.alphaShopDbContext.Articoli
                .Where(a => a.Descrizione!.Contains(Descrizione))
                .OrderBy(a => a.Descrizione)
                .ToList();
        }

        public Articoli SelArticoliByCodice(string Code)
        {
            return this.alphaShopDbContext.Articoli
                .Where(a => a.CodArt!.Equals(Code))
                .FirstOrDefault()!;            

        }

        public Articoli SelArticoliByEan(string Ean)
        {
            return this.alphaShopDbContext.Barcode
                .Where(a => a.Barcode!.Equals(Ean))
                .Select(a => a.articolo)
                .FirstOrDefault()!;
        }
        
        public bool DelArticoli(Articoli articolo)
        {
            throw new NotImplementedException();
        }

        public bool InsArticoli(Articoli articolo)
        {
            throw new NotImplementedException();
        }

        public bool Salva()
        {
            throw new NotImplementedException();
        }

        public bool UpdArticoli(Articoli articolo)
        {
            throw new NotImplementedException();
        }
    }
}