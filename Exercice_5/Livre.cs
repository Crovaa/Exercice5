using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5
{
    /// <summary>
    /// Cette classe est utilisé pour un exemple de documentation.
    /// <code>
    /// Livre livre = new Livre();
    /// livre.ArracherDesPages(4);
    /// </code>
    /// </summary>
    public class Livre
    {
        int Id;
        string Titre;
        int Nombre_Page;
        string Nom_Auteur;

        public Livre(int id, string titre, int nombre_page, string nom_auteur)
        {
            Id = id;
            Titre = titre;
            Nombre_Page = nombre_page;
            Nom_Auteur = nom_auteur;
        }
        /// <summary>
        /// Cette méthode écrase le .ToString() de base par une string de Titre et Nom_Auteur du livre.
        /// </summary>
        /// <returns> Retourne le titre du livre et nom de l'auteur.</returns>
        public override string ToString()
        {
            return Titre + Nom_Auteur;
        }
        /// <summary>
        /// Cette méthode permet d'arracher des pages à un livre.
        /// </summary>
        /// <param name="nombrePage">Définit le nombre de page arracher du livre.</param>
        public void ArracherDesPages(int nombrePage)
        {
            Nombre_Page -= nombrePage;
        }


    }
}
