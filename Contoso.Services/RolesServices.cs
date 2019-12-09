using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Models;

namespace Contoso.Services
{
    public class RolesServices
    {
        RolesRepository repo = new RolesRepository();
        public Role GetById(int id)
        {
            return repo.GetRolesById(id);
        }
    }
}
