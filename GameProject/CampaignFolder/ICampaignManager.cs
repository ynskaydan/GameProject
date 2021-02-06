using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignManager
    {
        string Name { get; set; }
        void DecreasePrice();
    }
}
