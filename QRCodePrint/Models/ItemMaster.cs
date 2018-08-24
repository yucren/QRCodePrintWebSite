using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LonKing.Model
{
    public class ItemMaster
    {
        public string 行号 { get; set; }
        public string 料号 { get; set; }

        public string 品名 { get; set; }
        public string 序列号 { get; set; }
        public string 供应商编码 { get; set; }

        public string fInfo
        {

            get
            {

                return "PC"+料号 +","+ 品名 + ",SN" + 序列号 +",VC" + 供应商编码;

            }

        }



    }
}