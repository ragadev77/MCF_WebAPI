using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using MCFWebAPI.Models;

namespace MCFWebAPI.Repositories
{
    public interface IMCFRepository
    {
        Task<IEnumerable<BPKB>> List_BPKB();
        BPKB Get_BPKB(string agreement_no);
        Location Get_Location(string location_id);
        Task<IEnumerable<Location>> List_Location();
        public void Add_BPKB(BPKB bpkb);
        public Task Del_BPKB(int id);
        public Task Update_BPKB(BPKB bpkb);        

    }
}
