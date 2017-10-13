using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_Ninjago
{
    class Joueur
    {
        int idJoueur;
        string pseudo;
        DateTime dateCreation;
        List<Carte> collectionCartes;

        public Joueur(int idJoueur, string pseudo, List<Carte> collectionCartes)
        {
            this.idJoueur = idJoueur;
            this.pseudo = pseudo;
            this.dateCreation = DateTime.Now;
            this.collectionCartes = new List<Carte>();
        }

        public int IdJoueur
        {
            get
            {
                return idJoueur;
            }

            set
            {
                idJoueur = value;
            }
        }

        public string Pseudo
        {
            get
            {
                return pseudo;
            }

            set
            {
                pseudo = value;
            }
        }

        public DateTime DateCreation
        {
            get
            {
                return dateCreation;
            }

            set
            {
                dateCreation = value;
            }
        }

        internal List<Carte> CollectionCartes
        {
            get
            {
                return collectionCartes;
            }

            set
            {
                collectionCartes = value;
            }
        }

        
        public void AjoutCarte (Carte nouvelle)
        {
            collectionCartes.Add(nouvelle);
        }
    }
}
