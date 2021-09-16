package com.example.inventaire;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        initialisation();
    }

    private void initialisation(){
        Button btNew = (Button) findViewById(R.id.BtMainAjout);
        Button btQuitter = (Button) findViewById(R.id.btMainQuit);
        Button btList = (Button) findViewById(R.id.btMainLis);

        // Fonction du bouton Quitter
        btQuitter.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
        // Fonction du bouton Ajout
        btNew.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent ajoutArticle = new Intent(MainActivity.this, AjoutArticleActivity.class);
                startActivity(ajoutArticle);
                //demarrerAjout();
            }
        });
        // Fonction du bouton Listing
        btList.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent listArticle = new Intent(MainActivity.this, ListeArticleActivity.class);
                startActivity(listArticle);
            }
        });

    }

   /* Function qui lance la deuxiement activité SANS passer par l'option onCLick
   * private  void demarrerAjout(){

    }*/
}