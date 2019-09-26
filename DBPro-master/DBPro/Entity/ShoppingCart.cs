﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBPro.Database;
namespace DBPro.Entity
{
    [DBTable("DBShoppingCart")]
    public class ShoppingCart
    {
        public ShoppingCart(string u_id,string i_id)
        {
            userID = u_id;
            itemID = i_id;
        }
        public ShoppingCart() { }

        [DBPrimaryKey("userID")]
        [DBMember("userId")]
        string userID { get; set; }
        [DBPrimaryKey("itemID")]
        [DBMember("itemID")]
        string itemID { get; set; }

    }
}
