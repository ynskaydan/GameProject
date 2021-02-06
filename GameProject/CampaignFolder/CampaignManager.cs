using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager
    {
        public void Decrease(ICampaignManager campaignManager)
        {
            campaignManager.DecreasePrice();


        }
    }
}
