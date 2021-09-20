use aboMultiSport;


-- création abonné
INSERT into abonne (id,nom,prenom,date_naissance,sexe,adresse,code_postal,ville,tel_fixe, portable,mail) VALUES ('1','dupond','charles','2010-10-10','M','12 rue du bois','21000','Dijon','0303030303','0606060606','bidon@gmail.com');
INSERT into abonne VALUES ('2','dubois','lucie','2000-07-15','F','avenue de la paix','39000','Lons-le-Saunier','0323035303','0607060696','test@gmail.com');
INSERT into abonne VALUES ('3','martin','spike','2005-10-10','M','1 rue de la rivière','21000','Dijon','0403430303','0603060506','spike@orange.com');
INSERT into abonne VALUES ('4','dupont','julia','1990-07-15','F','boulevard du jeu','39052','Dublin','0323035303','0687056696','djulia@gmail.com');
INSERT into abonne VALUES ('5','da re','kevin','1991-04-20','M','rue des champs élysée','21000','Dijon','0526534303','0602060026','individu@yahoo.fr');

-- création fréquence hebdomadaire
INSERT into frequence (id,frequence,majoration) VALUES ('1','deux','1');
INSERT into frequence VALUES ('2','quatre','1.25');
INSERT into frequence VALUES ('3','six','1.45');

-- création abonnement
INSERT into abonnement (id,type,prix) VALUES ('1','trimestriel','80');
INSERT into abonnement VALUES ('2','semestriel','130');
INSERT into abonnement VALUES ('3','annuel','220');

-- création activité
INSERT into activite (id,nom,prix_act) VALUES ('1','boxe','100');
INSERT into activite VALUES ('2','aerobic','100');
INSERT into activite VALUES ('3','gymnastique','100');
INSERT into activite VALUES ('4','musculation','100');
INSERT into activite VALUES ('5','natation','100');
INSERT into activite VALUES ('6','skateboard','100');

-- création cotisation
INSERT into cotisation (id,date_debut,type_reglement,montant,id_abonne,id_abonnement,id_frequence) VALUES ('1','2021-02-09','CB','180','1','1','1');
INSERT into cotisation VALUES ('2','2020-02-09','CH','519','2','3','3');
INSERT into cotisation VALUES ('3','2019-07-09','CB','262.50','5','2','2');
INSERT into cotisation VALUES ('4','2020-12-09','CH','520','3','3','1');
INSERT into cotisation VALUES ('5','2021-02-09','CH','519','2','3','3');

-- création dépendre
INSERT into dependre (id,id_cotisation) VALUES ('1','1');
INSERT into dependre VALUES ('2','2');
INSERT into dependre VALUES ('3','2');
INSERT into dependre VALUES ('6','3');
INSERT into dependre VALUES ('5','4');
INSERT into dependre VALUES ('4','4');
INSERT into dependre VALUES ('1','4');
INSERT into dependre VALUES ('2','5');
INSERT into dependre VALUES ('3','5');


