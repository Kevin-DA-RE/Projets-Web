package metier;

public class Article {
    private int id = 0;
    private String reference;
    private String designation;
    private Float prix;
    private int qte;



    // Constructeur initialisée
    public Article(int id, String reference, String designation, Float prix, int qte) {
        this.id = id;
        this.reference = reference;
        this.designation = designation;
        this.prix = prix;
        this.qte = qte;
    }

    // Constructeur surchargé
    public Article(String reference, String designation, Float prix, int qte) {
        this.reference = reference;
        this.designation = designation;
        this.prix = prix;
        this.qte = qte;
    }


    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getReference() {
        return reference;
    }

    public void setReference(String reference) {
        this.reference = reference;
    }

    public String getDesignation() {
        return designation;
    }

    public void setDesignation(String designation) {
        this.designation = designation;
    }

    public Float getPrix() {
        return prix;
    }

    public void setPrix(Float prix) {
        this.prix = prix;
    }

    public int getQte() {
        return qte;
    }

    public void setQte(int qte) {
        this.qte = qte;
    }
}
