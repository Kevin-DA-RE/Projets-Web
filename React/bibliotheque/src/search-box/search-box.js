import React from 'react';

import './search-box.css';

const Searchbox = props => ( // Création dde la barre de recherche
    <input 
    className="search-box"
    type='search'
    placeholder='rechercher une oeuvre'
    onChange={props.onSearchChange}
    />
)

export default Searchbox;