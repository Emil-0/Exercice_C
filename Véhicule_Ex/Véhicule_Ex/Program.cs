using System;

 namespace Voiture
 {
    class Program

    {
        public class Vehicule
        {
            // Propriétés
            protected string couleur;
            protected int poids;

            // Constructeur
            public Vehicule(string couleurVehicule, int poidsVehicule)
            {
                couleur = couleurVehicule;
                poids = poidsVehicule;
            }

            // Accesseur
            public string Couleur
            {
                get { return couleur; }
                set { couleur = value; }
            }
            public int Poids
            {
                get { return poids; }
                set { poids = value; }
            }

            // Méthodes
            public void Rouler()
            {
                Console.WriteLine("Le véhicule roule");

            }
            public void AjouterPersonne(int poidsPersonne, int nombrePersonnes = 1)
            {
                poids += poidsPersonne * nombrePersonnes;
            }

            // Création d'une classe dériver de Véhicule
            public class Quatre_Roues : Vehicule
            {
                private int nombrePortes;

                // Contructeur (d'une classe dérivée)
                public Quatre_Roues(string couleur, int poids, int nombrePortesVehicule) : base(couleur, poids)
                {
                    nombrePortes = nombrePortesVehicule;
                }

                // Accesseur
                public int NombrePortes
                {
                    get { return nombrePortes; }
                    set { nombrePortes = value; }
                }

                // Méthodes
                public void Repeindre(string couleurPeinture)
                {
                    couleur = couleurPeinture;
                    Console.WriteLine($"Véhicule repeint en {couleurPeinture}.");
                }

            }

            // Deuxième classe dériver de Véhicule
            public class Deux_Roues : Vehicule
            {
                private int cylindree;

                // Constructeur
                public Deux_Roues(string couleur, int poids, int Cylindree) : base(couleur, poids)
                {
                    cylindree = Cylindree;
                }

                // Accesseur
                public int Cylindree
                {
                    get { return cylindree; }
                    set { cylindree = value; }
                }

                // Méthodes
                public void Mettre_essence(int litre)
                {
                    poids += litre;
                }

            }

            // Troisème classe dériver de Véhicule
            public class Voiture : Quatre_Roues
            {
                private int nombre_pneu_neige;

                // Constructeur
                public Voiture(string couleur, int poids, byte nombre_porte = 5, byte Nombre_Pneu_Neige = 0) : base(couleur, poids, nombre_porte)
                {
                    nombre_pneu_neige = Nombre_Pneu_Neige;
                }

                // Accesseur
                public int Nombre_Pneu_Neige
                {
                    get { return nombre_pneu_neige; }
                    set { nombre_pneu_neige = value; }
                }

                // Méthodes
                public void Ajouter_pneu_neige(int nombre)
                {
                    nombre_pneu_neige += nombre;
                }
                public void Enlever_pneu_neige(int nombre)
                {
                    nombre_pneu_neige -= nombre;
                }
            }

            // Quatrième Classe dériver de Véhicule
            public class Camion : Quatre_Roues
            {
                int longueur;

                // Constructeur
                public Camion(string couleur, int poids, byte nombre_porte, int Longueur) : base(couleur, poids, nombre_porte)
                {
                    longueur = Longueur;
                }

                // Accesseur
                public int Longueur
                {
                    get { return longueur; }
                }

                // Méthodes
                public void Ajouter_remorque(int longueur_remorque)
                {
                    longueur += longueur_remorque;
                }
            }

            static void Main(string[] args)
            {
                Vehicule voiturePorche;
                voiturePorche = new Vehicule("Noir", 1500);
                Console.WriteLine("Mon véhicule est : " + voiturePorche.Couleur);
                Console.WriteLine("Le poids du véhicule est : " + voiturePorche.Poids);
                voiturePorche.Rouler();
                voiturePorche.AjouterPersonne(70);
                Console.WriteLine($"La voiture repeinte en {voiturePorche.Couleur} pèse {voiturePorche.Poids} Kg.");

                // Créer une voiture vertre de 1400 Kg.
                Voiture voitureMercecedes = new Voiture("Verte", 1400);

                // Ajouter deux personnes de 65 Kg chacune.
                // Afficher dans la console sa couleur et son nouveau poids.
                voitureMercecedes.AjouterPersonne(65, 2);
                Console.WriteLine($"La Mercedez {voitureMercecedes.couleur} pèse {voitureMercecedes.poids}Kg.");

                // Repeindre la voiture en rouge et ajouter deux pneus neige.
                voitureMercecedes.Repeindre("Rouge");
                voitureMercecedes.Ajouter_pneu_neige(2);
                // Afficher dans la console sa couleur et son nombre de pneus neige.
                Console.WriteLine($"La Mercedez repeinte en {voitureMercecedes.Couleur} possède {voitureMercecedes.Nombre_Pneu_Neige} pneus neige");

                // Créer un objet Deux_roues noir de 120 Kg.
                Deux_Roues motoDucati = new Deux_Roues("Noir", 120, 4);
                Console.WriteLine($"la moto Ducati est {motoDucati.couleur}.");
                // Ajouter une personne de 80 Kg.
                motoDucati.AjouterPersonne(80);
                Console.WriteLine($"la moto Ducati est de {motoDucati.Poids} Kg.");
                // Mettre 20 Litres d'essence.
                motoDucati.Mettre_essence(20);
                // Afficher dans la console la couleur et le poids du deux roues.
                Console.WriteLine($"La Ducati de couleur {motoDucati.Couleur} pèse {motoDucati.Poids} Kg.");

                // Créer un camion bleu de 10000 Kg d'ne longeur de 10 mètres avec deux Portes.
                Camion camionIveco = new Camion("Bleu", 10000, 2, 10);
                Console.WriteLine($"Le camion Iveco {camionIveco.Couleur} pèse {camionIveco.Poids} Kg, de longeur de {camionIveco.Longueur} mètre avec {camionIveco.NombrePortes} portes.");
                // Lui ajouter une remorque de 5 mètres et une personne de 80 Kg.
                camionIveco.Ajouter_remorque(5);
                camionIveco.AjouterPersonne(80);
                // Afficher dans la console sa couleur, son poids, sa longeur et son nombre de portes.
                Console.WriteLine($"Le camion Iveco {camionIveco.Couleur} qui pèse {camionIveco.Poids} Kg avec une longeur de {camionIveco.Longueur} mètres à {camionIveco.NombrePortes} portes. ");


            }
        }
    }
 }