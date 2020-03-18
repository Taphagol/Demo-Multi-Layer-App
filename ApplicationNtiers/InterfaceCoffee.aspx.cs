using LC_ENT;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationNtiers
{
    public partial class InterfaceCoffee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonObtenir_Click(object sender, EventArgs e)
        {
            //CoffeeEntite cafegui = LC_ENTTR.ConnectionClass.GetCoffeeByType("classic");

            CoffeeEntite cafegui = new CoffeeEntite();
            cafegui.Type = "classic";

            CoffeeEntite retour1 = null;
            List<CoffeeEntite> retour = null;
            LC_CDA.CoffeeCDA pourAppel = new LC_CDA.CoffeeCDA();
            //retour1 = pourAppel.ObtenirInfoCoffee(cafegui);
            retour = pourAppel.RechercherTP(cafegui);

            LabelID.Text = retour[0].Id.ToString();
            LabelName.Text = retour[0].Name;
            LabelType.Text = retour[0].Type;
            LabelPrice.Text = retour[0].Price.ToString();

            //LabelID.Text = retour1.Id.ToString();
            //LabelName.Text = retour1.Name;
            //LabelType.Text = retour1.Type;
            //LabelPrice.Text = retour1.Price.ToString();  
 
        }
    }
}