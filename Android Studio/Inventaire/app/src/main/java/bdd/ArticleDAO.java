package bdd;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.util.Log;

import metier.Article;

public class ArticleDAO {
    private static final int    VERSION_BDD =       1;
    private static final String NOM_BDD =           "article.db";
    private static final String TABLE_ARTICLE =     "article";
    protected SQLiteDatabase db =                   null;
    protected  CreateBdArticle createDb =           null;


    public ArticleDAO(Context context) {
        createDb = new CreateBdArticle(context , NOM_BDD, null, VERSION_BDD);
    }

    /**
     * Constructeur
     * @param //context
     */

    public SQLiteDatabase open() {
        db = createDb.getWritableDatabase(); Log.d("BDD", "Base ouverte");
        return db;
    }

    /**
     * Fermeture de la base
     */
    public void close() {
        db.close();
    }
    /**
     * Ajout de l'article passé en paramètre dans la base de données
     * @param a : Article à ajouter
     * @return : no de ligne ajouté
     */
    public long create(Article a) {
        ContentValues values = new ContentValues(); // Ensemble des valeurs à insérer, (eq HashMap)
        values.put("ref", a.getReference());
        values.put("des", a.getDesignation());
        values.put("pu", a.getPrix());
        values.put("qte", a.getQte());
        Log.d("BDD","create, ref : " + a.getReference()); Log.d("BDD","create, des : " + a.getDesignation()); Log.d("BDD","create, pu : " + a.getPrix()); Log.d("BDD","create, qte : " + a.getQte());
        return db.insert(TABLE_ARTICLE, null, values);
    }

    public Cursor readLesArticles(){
        // Requête
        String reqSQL = "SELECT id as '_id', ref , des, pu ,qte FROM " + TABLE_ARTICLE;
        Log.d("BDD", reqSQL);
        // Execution de la requête
        Cursor c = db.rawQuery(reqSQL, null);
        Log.d("BDD", "Le curseur contient " + c.getCount() + " lignes");
        return c;
    }
}
