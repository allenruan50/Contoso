using Contoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class RolesRepository
    {
        ContosoDbContext Db = new ContosoDbContext();
        public Role GetRolesById(int id)
        {
            return Db.Roles.FirstOrDefault(r => r.Id == id);
        }

    }
}
