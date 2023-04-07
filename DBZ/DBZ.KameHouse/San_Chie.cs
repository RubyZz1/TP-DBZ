using DBZ.Dojo.Vestiaires;

namespace DBZ.KameHouse
{
    public class San_Chie : IGuerrier
    {
        public string Nom
        {
            get
            {
                return "San_Chie";
            }
        }

        private bool _jeSuisCharge;

        public ActionDeCombat ChoixProchaineAction(ActionDeCombat dernierActionAdversaire)
        {
            if (dernierActionAdversaire == ActionDeCombat.KameHameHa)
            {
                if (!this._jeSuisCharge)
                {
                    this._jeSuisCharge = true;
                    return ActionDeCombat.KameHameHa;
                }else
                {
                    this._jeSuisCharge = false;
                    return ActionDeCombat.ChargeKameHameHa;
                }
            }
            else if (dernierActionAdversaire == ActionDeCombat.Parade)
            {
                return ActionDeCombat.ChargeKameHameHa;
            }
            else
            {
                return ActionDeCombat.Parade;
            }
        }
    }
}