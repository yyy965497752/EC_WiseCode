using System;
using System.Collections.Generic;
using System.Text;

namespace EC_Models
{
    public class WalletModel
    {
        public int Id { get; set; }
        public decimal yueMoney { get; set; }


        public string yueMoney1 { get => yueMoney.ToString("C"); }


        public decimal dayMoney { get; set; }
        public string dayMoney1 { get => dayMoney.ToString("C"); }

        public decimal dayModeryZc { get; set; }
        public string dayModeryZc1 { get => dayModeryZc.ToString("C"); }

        public decimal leijishouru { get; set; }
        public string leijishouru1 { get => leijishouru.ToString("C"); }

        public decimal leijizhichu { get; set; }
        public string leijizhichu1 { get => leijizhichu.ToString("C"); }

    }
}
