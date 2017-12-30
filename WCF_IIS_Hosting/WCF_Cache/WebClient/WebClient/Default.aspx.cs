﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnPizza_Click(object sender, EventArgs e)
        {
            using (PizzaService.PizzaServiceClient client = new PizzaService.PizzaServiceClient())
            {
                List<string> pizzaTypes = client.GetAvailablePizzas().ToList<string>();
                lstPizza.DataSource = pizzaTypes;
                lstPizza.DataBind();
            }
        }
    }
}