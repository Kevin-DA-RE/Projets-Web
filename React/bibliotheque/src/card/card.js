import React from 'react';

import './card.css';

const Card = (props) => (
    <div className='card-container'>
        <img
            alt="Oeuvre"
            className="image"
            src={props.oeuvre.imageUrl}
        />
        <h2>{props.oeuvre.titre}</h2>
        <p>
            {props.oeuvre.auteur} - {props.oeuvre.annee}
        </p>


    </div>

);

export default Card;