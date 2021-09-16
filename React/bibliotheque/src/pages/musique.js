import React, {useState, useEffect} from 'react';
import './films.css';
import Searchbox from '../search-box/search-box.js';
import CardList from '../card-list/card-list.js';

// let musiques = [

//     {
//         id: 1,
//         auteur: "NIGHTWISH",
//         annee: "2004",
//         titre: "Nemo",
//         imageUrl: "https://images.genius.com/ecffb33ce23eca61be4d78119c1c3f18.500x500x1.jpg"
//     },
//     {
//         id: 2,
//         auteur: "AC DC",
//         annee: "1990",
//         titre: "Thundestruck",
//         imageUrl: "https://upload.wikimedia.org/wikipedia/en/e/e4/ACDC-Thunderstruck.png"
//     },
//     {
//         id: 3,
//         auteur: "RAMMSTEIN",
//         annee: "1997",
//         titre: "Angel",
//         imageUrl: "https://cdn.rammsteinworld.com/uploads/galerie/clips/clip-engel/Engel_[www_rammsteinworld_com]_(14).jpg"
//     },
//     {
//         id: 4,
//         auteur: "Lindsey Stirling",
//         annee: "2014",
//         titre: "Roundtable Rivals",
//         imageUrl: "https://i.pinimg.com/originals/d9/86/a0/d986a037da8e3473c9c661f71e68322d.jpg"
//     },
//     {
//         id: 5,
//         auteur: "Sia",
//         annee: "2016",
//         titre: "Move your body",
//         imageUrl: "https://i.ytimg.com/vi/vxrSAwtdtuQ/maxresdefault.jpg"
//     },

// ]

const Musiques = (props) => {
        const [searchField, sertSearchField] = useState('');
        const [musiques, setMusiques] = useState([]);

        useEffect(() => {
            fetch(
                'http://localhost:5001/api/musiques',
                {
                    method: "GET", 
                    headers: {
                        'Content-Type' : 'application/json'
                    }
                }
            ).then(res => {
                if (res.status !== 200 && res.status !== 201){
                    throw new Error('Erreur');
                }
                return res.json();
            }).then(res => {
                setMusiques (res.musiques);
            }).catch(error =>{
                console.log(error);
            })
        })



        const onSearchChange = event => {
            sertSearchField(event.target.value);
            //console.log(searchField);
        }
        const filteredMusiques = musiques.filter(musique =>
            musique.titre.toLowerCase().includes(searchField.toLowerCase())
            );

    return (
        <div>
            <Searchbox  onSearchChange={onSearchChange}/>
            <CardList oeuvres={filteredMusiques} />
        </div>
    );
}

export default Musiques;