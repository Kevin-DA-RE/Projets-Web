#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------

DROP DATABASE IF EXISTS aboMultiSport;
CREATE DATABASE aboMultiSport;
USE aboMultiSport;
#------------------------------------------------------------
# Table: abonne
#------------------------------------------------------------

CREATE TABLE abonne(
        id             Int  Auto_increment  NOT NULL ,
        nom            Varchar (50) NOT NULL ,
        prenom         Varchar (50) NOT NULL ,
        date_naissance Date NOT NULL ,
        sexe           Varchar (1) NOT NULL check (sexe in ('M', 'F')) ,
        adresse        Varchar (50) NOT NULL ,
        code_postal    Varchar (50) NOT NULL ,
        ville          Varchar (50) NOT NULL ,
        tel_fixe       Int NOT NULL ,
        portable       Varchar (50) NOT NULL ,
        mail           Varchar (50) NOT NULL
	,CONSTRAINT abonne_PK PRIMARY KEY (id)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: activite
#------------------------------------------------------------

CREATE TABLE activite(
        id       Int  Auto_increment  NOT NULL ,
        nom      enum ("aerobic", "boxe", "gymnastique", "musculation", "natation", "skateboard") NOT NULL,
        prix_act Float check (prix_act in ("100")) NOT NULL,
	CONSTRAINT activite_PK PRIMARY KEY (id)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: abonnement
#------------------------------------------------------------

CREATE TABLE abonnement(
        id   Int  Auto_increment  NOT NULL ,
        type enum ("trimestriel", "semestriel", "annuel") NOT NULL,
        prix enum ("80","130","220") NOT NULL,
	CONSTRAINT abonnement_PK PRIMARY KEY (id)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: frequence
#------------------------------------------------------------

CREATE TABLE frequence(
        id         Int  Auto_increment  NOT NULL ,
        frequence  enum ("deux" ,"quatre" ,"six") NOT NULL,
        majoration enum ("1","1.25","1.45") NOT NULL
	,CONSTRAINT frequence_PK PRIMARY KEY (id)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: cotisation
#------------------------------------------------------------

CREATE TABLE cotisation(
        id             Int  Auto_increment  NOT NULL ,
        date_debut     Date NOT NULL ,
        type_reglement Varchar (2) NOT NULL check (type_reglement in ('CH', 'CB')),
        montant 	   float NOT NULL,
        id_abonne      Int NOT NULL ,
        id_abonnement  Int NOT NULL ,
        id_frequence   Int NOT NULL
	,CONSTRAINT cotisation_PK PRIMARY KEY (id)

	,CONSTRAINT cotisation_abonne_FK FOREIGN KEY (id_abonne) REFERENCES abonne(id)
	,CONSTRAINT cotisation_abonnement0_FK FOREIGN KEY (id_abonnement) REFERENCES abonnement(id)
	,CONSTRAINT cotisation_frequence1_FK FOREIGN KEY (id_frequence) REFERENCES frequence(id)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: dependre
#------------------------------------------------------------

CREATE TABLE dependre(
        id            Int NOT NULL ,
        id_cotisation Int NOT NULL
	,CONSTRAINT dependre_PK PRIMARY KEY (id,id_cotisation)

	,CONSTRAINT dependre_activite_FK FOREIGN KEY (id) REFERENCES activite(id)
	,CONSTRAINT dependre_cotisation0_FK FOREIGN KEY (id_cotisation) REFERENCES cotisation(id)
)ENGINE=InnoDB;

