import React from 'react';
import { NavLink } from "react-router-dom";

import "./header.css"

const Header = () => {
    return (
        <div className="main-header">
            <ul className="nav-links">
                <li>
                    <NavLink to="/" exact> 
                        films
                    </NavLink>
                </li>
                <li><NavLink to="/musiques">
                        musiques
                    </NavLink>
                </li>
            </ul>

        </div>
    )
}
// films Page d'acceuil
// <ul className="nav-links"> permet de creer des boutons

export default Header;