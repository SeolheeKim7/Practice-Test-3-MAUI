using Practice_Test_3_MAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Test_3_MAUI.Data
{
    internal interface IBatmanSayingRepository
    {
        Task<BatmanSaying> GetSaying();
    }
}
