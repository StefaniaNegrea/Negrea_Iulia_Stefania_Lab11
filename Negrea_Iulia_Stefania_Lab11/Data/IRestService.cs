using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negrea_Iulia_Stefania_Lab11.Models;

namespace Negrea_Iulia_Stefania_Lab11.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshingDataAsync();

        Task SaveShopListAsync(ShopList item, bool isNewItem);

        Task DeleteShopListAsync(int id);

    }
}
