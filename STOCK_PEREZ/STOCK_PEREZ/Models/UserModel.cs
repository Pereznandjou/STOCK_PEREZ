using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace STOCK_PEREZ.Models
{
   public class UserModel
    {
        public int Telephone { get; set; }
        public string Name { get; set; }
        public Bitmap bitmap { get; set; }

        public UserModel()
        {

        }

        public UserModel(int telephone, string name)
        {
            Telephone = telephone;
            Name = name;
        }
    }
}
