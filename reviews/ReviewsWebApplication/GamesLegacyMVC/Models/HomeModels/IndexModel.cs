using GamesLegacySQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamesLegacyMVC.Models.HomeModels
{
    public class IndexModel
    {
        public IEnumerable<LegacyDTOGame> Games { get; private set; }

        public IndexModel(IEnumerable<LegacyDTOGame> games)
        {
            Games = games;
        }
    }
}