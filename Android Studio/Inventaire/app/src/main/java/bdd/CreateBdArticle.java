package bdd;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;

import androidx.annotation.Nullable;

public class CreateBdArticle extends SQLiteOpenHelper {

    private static String TABLE_ARTICLE = "article";
    private static final String CREATE_BDD = "CREATE TABLE " + TABLE_ARTICLE + "(" +
            "id INTEGER PRIMARY KEY AUTOINCREMENT, " +
            "ref TEXT NOT NULL, " +
            "des TEXT NOT NULL, " +
            "pu REAL," +
            "qte INTEGER);";

    public CreateBdArticle(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL(CREATE_BDD);
        Log.d("BDD", "Base créée");
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("DROP TABLE " + TABLE_ARTICLE + ";");
        Log.d("BDD", "Table article supprimée");
        onCreate(db);
    }
}
