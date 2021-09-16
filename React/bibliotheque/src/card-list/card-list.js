import React from 'react';

import './card-list.css';

import Card from '../card/card.js';

const CardList = (props) => (
    <div className='card-list'>

        {props.oeuvres.map((oeuvre) => (
            <Card key={oeuvre.id} oeuvre={oeuvre} />
        ))}

    </div>
);

export default CardList;