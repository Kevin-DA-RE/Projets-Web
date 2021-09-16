package com.example.inventaire;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import bdd.ArticleDAO;
import metier.Article;

public class AjoutArticleActivity extends AppCompatActivity {

    // Contrôles graphiques
    private EditText etRef;
    private EditText etDes;
    private EditText etPrix;
    private EditText etQte;
    private Button   btAjout;

    // Valeur saisies
    String  ref;
    String  des;
    String  prix;
    double  prixN;
    String  qte;
    int     qteN;
    Article art;
    long    idArticleCree;
    ArticleDAO  artDAO;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ajout_article);
        ButtonsActions();
        gererCreationArticle();
    }

    private  void  ButtonsActions(){
        Button btQuitAjout = (Button) findViewById(R.id.btQuitArticle);

        btQuitAjout.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });


        Button btAjoutArticle = (Button) findViewById(R.id.btAjoutArticle);

        btAjoutArticle.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent listArticle = new Intent(AjoutArticleActivity.this, ListeArticleActivity.class);
                startActivity(listArticle);
            }
        });

    }

    private void gererCreationArticle(){
        etRef = (EditText)  findViewById(R.id.etReferenceArticle);
        etDes = (EditText)  findViewById(R.id.etDesignArticle);
        etPrix = (EditText) findViewById(R.id.etAjoutPrixArticle);
        etQte = (EditText)  findViewById(R.id.etQteArticle);
        btAjout = (Button)  findViewById(R.id.btAjoutArticle);

        artDAO = new ArticleDAO(this);
        artDAO.open();

        btAjout.setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View v) {
                ref = etRef.getText().toString();
                des = etDes.getText().toString();
                prix = etPrix.getText().toString();
                prixN = Float.valueOf(prix);
                qte = etQte.getText().toString();
                qteN = Integer.valueOf(qte);

                art = new Article(ref, des, (float) prixN, qteN);

                idArticleCree = artDAO.create(art);

                Toast.makeText(getApplicationContext(), "Produit ajouté + " + "(no : " + idArticleCree + " )", Toast.LENGTH_SHORT).show();

                etRef.setText("");
                etRef.requestFocus();
                etDes.setText("");
                etPrix.setText("");
                etQte.setText("");

                artDAO.close();
                finish();
                Intent listArticle = new Intent(AjoutArticleActivity.this, ListeArticleActivity.class);
                startActivity(listArticle);
            }
        });
    }
}