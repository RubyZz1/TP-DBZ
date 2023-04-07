namespace Motus.Core
{
    public class CalculMotService : ICalculMotService
    {
        public EssaiMot CalculMot(string tentative, string motADeviner)
        {
            var essaiMot = new EssaiMot();

            // Split des lettres de la tentative et du mot à deviner
            var lettresTentative = tentative.ToCharArray();
            var lettresMotADeviner = motADeviner.ToCharArray();

            // Création de la liste des lettres avec leur état initial
            var lettres = new List<Lettre>();
            for (var i = 0; i < lettresTentative.Length; i++)
            {
                var lettre = new Lettre
                {
                    Caractere = lettresTentative[i],
                    Etat = EtatLettre.MauvaiseLettre
                };
                lettres.Add(lettre);
            }

            // Vérification de la correspondance lettre par lettre
            for (var i = 0; i < lettresTentative.Length; i++)
            {
                var lettreTentative = lettresTentative[i];

                // Bonne lettre à la bonne place
                if (lettreTentative == lettresMotADeviner[i])
                {
                    lettres[i].Etat = EtatLettre.OK;
                }
                // Bonne lettre à la mauvaise place
                else if (lettresMotADeviner.Contains(lettreTentative))
                {
                    lettres[i].Etat = EtatLettre.BonneLettreMalPlacee;
                }
            }

            // Affectation des lettres à l'objet EssaiMot
            essaiMot.Lettres = lettres;

            return essaiMot;
        }
    }
}