using System;
using System.Globalization;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Newtonsoft.Json;

using MCFWebAPI.Models;

namespace MCFWebAPI.Repositories
{
    public class MCFRepository : IMCFRepository
    {
        private readonly APIDbContext _context;

        public MCFRepository(APIDbContext context)
        {
            _context = context;
        }

        //public IQueryable<BPKB> BPKBs => _context.BPKBs.Include(p => p.Location);
        public IQueryable<Location> Locations => _context.Locations;
        public async Task<IEnumerable<BPKB>> List_BPKB()
        {
            return await _context.BPKBs.ToListAsync();
        }
        public BPKB Get_BPKB(string agreement_no)
        {
            var data = _context.BPKBs.Find(agreement_no);
            return data;
        }
        public Location Get_Location(string location_id)
        {
            var data = _context.Locations.Find(location_id);
            return data;
        }
        public async Task<IEnumerable<Location>> List_Location()
        {
            return await _context.Locations.ToListAsync();
        }

        /* region non-query */
        public void Add_BPKB(BPKB bpkb)
        {
            try
            {
                if (bpkb.agreement_number == "")
                {
                    _context.BPKBs.Add(bpkb);
                }
                else
                {
                    BPKB entry = new BPKB();
                    entry.agreement_number = bpkb.agreement_number;
                    entry.bpkb_no = bpkb.bpkb_no;
                    entry.bpkb_date = DateTime.ParseExact(bpkb.bpkb_date.ToShortDateString(), "d", CultureInfo.InvariantCulture);
                    entry.faktur_no = bpkb.faktur_no;
                    entry.faktur_date = bpkb.faktur_date;
                    entry.Location = _context.Locations.FirstOrDefault(p => p.locationId == bpkb.LocationId);
                    entry.police_no = bpkb.police_no;
                    entry.bpkb_date_in = bpkb.bpkb_date_in;

                    _context.BPKBs.Add(entry);
                }
                _context.SaveChanges();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public async Task Del_BPKB(int id)
        {
            var delData = await _context.BPKBs.FindAsync(id);
            _ = _context.BPKBs.Remove(delData);
            await _context.SaveChangesAsync();
        }

        public async Task Update_BPKB(BPKB bpkb)
        {
            _context.Entry(bpkb).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
