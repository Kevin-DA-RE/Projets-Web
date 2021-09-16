package com.example.inventaire;

import androidx.appcompat.app.AppCompatActivity;

import android.database.Cursor;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.ListView;
import android.widget.SimpleCursorAdapter;
import android.widget.Toast;

import bdd.ArticleDAO;

public class ListeArticleActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_liste_article);
        quitList();
        afficherLesArticles();
    }

    private void quitList(){
        Button btQuitList = (Button) findViewById(R.id.btQuitList);

        btQuitList.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
    }

    private void afficherLesArticles(){
        Log.d("BDD", "Debut afficherLesArticles");

        // Accès à la base de données
        ArticleDAO artDAO = new ArticleDAO(this);
        Log.d("BDD", "artDAO accessible");
        artDAO.open();
        Log.d("BDD", "open réussi");

        // Récupération des articles dans un curseur
        Cursor c = artDAO.readLesArticles();
        Toast.makeText(getApplicationContext(), "Il y a " + c.getCount() + "article(s)",
                Toast.LENGTH_SHORT).show();
        artDAO.close();

        // Nom des 4 attributs lus de la base de données
        String[] from = new String[] {"ref", "des", "pu", "qte"};
        // Références des contrôles graphiques qui afficheront les valeurs
        int[] to = new int[] {R.id.tvRef, R.id.tvDes, R.id.tvPrix, R.id.tvQte};
        // Adapter : lien entre les données et les contrôles graphiques
        SimpleCursorAdapter dataAdapter = new SimpleCursorAdapter(this, R.layout.ligne_article, c, from, to, 0);
        // Affectation de l'adapter à la listeViev
        ListView lvArticle = (ListView) findViewById(R.id.lvArticle);
        lvArticle.setAdapter((dataAdapter));
    }
}