import React, {useState} from 'react';
import './films.css';
import CardList from '../card-list/card-list.js';
import Searchbox from '../search-box/search-box.js';

const films = [

    {
        id: 1,
        auteur: "Walt Disney",
        annee: "2019",
        titre: "Le roi Lion",
        imageUrl: "https://fr.web.img6.acsta.net/medias/nmedia/18/85/97/82/19858447.jpg"
    },
    {
        id: 2,
        auteur: "Marvel Studios",
        annee: "2019",
        titre: "Avengers Endgame",
        imageUrl: "https://images-na.ssl-images-amazon.com/images/I/81%2BNup8-8NL._AC_SY445_.jpg"
    },
    {
        id: 3,
        auteur: "Bob Gale et Robert Zemeckis",
        annee: "1985",
        titre: "Retour Vers Le Futur",
        imageUrl: "https://cdn.radiofrance.fr/s3/cruiser-production/2015/10/d7c3520e-0101-4ecf-80b3-866c5f17f873/870x489_dolorian-retour-vers-le-futur.jpg"
    },
    {
        id: 4,
        auteur: "Georges Lucas",
        annee: "2005",
        titre: "Star Wars Episode 3: La revanche des Siths",
        imageUrl: "https://fr.web.img3.acsta.net/medias/nmedia/18/35/53/23/18423997.jpg"
    },
    {
        id: 5,
        auteur: "Jake Kasdan",
        annee: "2019",
        titre: "Jumanji: the next level",
        imageUrl: "https://www.ecran-et-toile.com/uploads/5/5/8/7/55875205/unnamed-15_1_orig.jpg"
    },

]

const Films = () => {
    const [searchField, sertSearchField] = useState('');
    const onSearchChange = event => { // Mémorisation des caractères frappés au clavier
        sertSearchField(event.target.value);
        //console.log(searchField);
    }
    const filteredFilms = films.filter(film => // Filtre les éléments en fonction de se que l'on tape
        film.titre.toLowerCase().includes(searchField.toLowerCase())
        );


    return (
        <div>
            <Searchbox  onSearchChange={onSearchChange}/>
            <CardList oeuvres={filteredFilms} />
        </div>

    );

}

export default Films;