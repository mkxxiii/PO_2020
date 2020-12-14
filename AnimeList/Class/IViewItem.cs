using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeList.Class
{
    public interface IViewItem
    {
        public MensageTransporter Message { get; set; }
    }
}
